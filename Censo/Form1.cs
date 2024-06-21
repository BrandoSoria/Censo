using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Serialization;

namespace Censo
{
    public partial class Form1 : Form
    {
        private Conexion con;
        private DataSet oDS;
        private System.Windows.Forms.ToolTip toolTip1;
        private bool isNewRowBeingAdded = false;

        public Form1()
        {
            InitializeComponent();
            con = new Conexion();
            oDS = new DataSet();
            toolTip1 = new System.Windows.Forms.ToolTip();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ConfigurarComboBox();
            ConfigurarEventos();
            DisenoDatos();
            this.WindowState = FormWindowState.Maximized;
        }

        //Funcion principal
        private void CargarDatos(string lineaFiltro = null)
        {
            SqlConnection connection = null;  // Inicializar la variable de conexi�n fuera del try

            try
            {
                connection = con.AbrirConexion();  // Abrir la conexi�n

                string query = "SELECT * FROM InformacionEquipos";

                if (lineaFiltro != null && lineaFiltro != "Todas las l�neas")
                {
                    query += $" WHERE Linea = '{lineaFiltro}'";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                // Limpia el DataSet antes de llenarlo
                oDS.Clear();
                adapter.Fill(oDS, "InformacionEquipos");

                dgvCenso.DataSource = oDS.Tables["InformacionEquipos"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                {
                    con.CerrarConexion();  // Cerrar la conexi�n en el bloque finally
                }
            }

            comboBoxLineas.DataSource = oDS.Tables["Linea"];
            comboBoxLineas.DisplayMember = "Linea";
            comboBoxLineas.ValueMember = "Linea";
        }



        private void DisenoDatos()
        {
            lbl_Censo.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Censo.Font = new Font("Myanmar", 20, FontStyle.Bold);
            lbl_Censo.ForeColor = Color.Indigo;
            btnActualizar.Visible = false;
            this.btnGuardar.Visible = false;

            DataGridViewCellStyle styleCelda = new DataGridViewCellStyle
            {
                Font = new Font("Calibri", 11, FontStyle.Regular),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.WhiteSmoke,
                ForeColor = Color.Indigo,
            };

            DataGridViewCellStyle styleTitulo = new DataGridViewCellStyle
            {
                Font = new Font("Calibri", 12, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
            };

            dgvCenso.RowsDefaultCellStyle = styleCelda;
            dgvCenso.ColumnHeadersDefaultCellStyle = styleTitulo;

            foreach (DataGridViewColumn column in dgvCenso.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvCenso.RowTemplate.DefaultCellStyle.Padding = new Padding(2);
            dgvCenso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvCenso.AllowUserToAddRows = false;
            dgvCenso.AllowUserToDeleteRows = false;
            dgvCenso.AllowUserToOrderColumns = false;
            dgvCenso.RowTemplate.MinimumHeight = 28;
            dgvCenso.ReadOnly = true;
        }

        //Carteles en iconos
        private void pbAgregar_MouseHover(object sender, EventArgs e)
        {
            int offsetX = -120;
            int offsetY = 20;
            Point locationOnForm = pbAgregar.PointToClient(Cursor.Position);
            Point newLocation = new Point(locationOnForm.X + offsetX, locationOnForm.Y + offsetY);
            toolTip1.Show("Agregar equipo", pbAgregar, newLocation);
        }

        private void pbAgregar_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(pbAgregar);
        }

        private void pbEditar_MouseHover(object sender, EventArgs e)
        {
            int offsetX = -120;
            int offsetY = 20;
            Point locationOnForm = pbEditar.PointToClient(Cursor.Position);
            Point newLocation = new Point(locationOnForm.X + offsetX, locationOnForm.Y + offsetY);
            toolTip1.Show("Editar equipo", pbEditar, newLocation);
        }

        private void pbEditar_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(pbEditar);
        }

        private void pbEliminar_MouseHover(object sender, EventArgs e)
        {
            int offsetX = -120;
            int offsetY = 20;
            Point locationOnForm = pbEliminar.PointToClient(Cursor.Position);
            Point newLocation = new Point(locationOnForm.X + offsetX, locationOnForm.Y + offsetY);
            toolTip1.Show("Eliminar equipo", pbEliminar, newLocation);
        }

        private void pbEliminar_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(pbEliminar);
        }

        private void pbSalir_MouseHover(object sender, EventArgs e)
        {
            int offsetX = -120;
            int offsetY = 20;
            Point locationOnForm = pbSalir.PointToClient(Cursor.Position);
            Point newLocation = new Point(locationOnForm.X + offsetX, locationOnForm.Y + offsetY);
            toolTip1.Show("Cerrar sesion", pbSalir, newLocation);
        }

        private void pbSalir_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(pbSalir);
        }


        //Funciones

        private void ConfigurarComboBox()
        {
            comboBoxLineas.Items.Clear(); // Limpiar los elementos existentes en el ComboBox

            comboBoxLineas.Items.Add("Todas las líneas");

            var lineasUnicas = oDS.Tables["InformacionEquipos"].AsEnumerable()
                .Select(row => row.Field<string>("Linea"))
                .Distinct();

            foreach (var linea in lineasUnicas)
            {
                if (!comboBoxLineas.Items.Contains(linea))
                {
                    comboBoxLineas.Items.Add(linea);
                }
            }

            comboBoxLineas.SelectedIndex = 0;
        }


        private void ConfigurarEventos()
        {
            comboBoxLineas.SelectedIndexChanged += new EventHandler(comboBoxLineas_SelectedIndexChanged);
        }


        private void comboBoxLineas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lineaSeleccionada = comboBoxLineas.SelectedItem.ToString();
            CargarDatos(lineaSeleccionada);
        }


        private void pbAgregar_Click(object sender, EventArgs e)
        {
            sAgregar();
        }


        private void sAgregar()
        {
            if (dgvCenso.IsCurrentCellInEditMode)
                return;

            if (dgvCenso.Columns.Count == 0)
            {
                foreach (DataColumn columna in oDS.Tables["InformacionEquipos"].Columns)
                {
                    dgvCenso.Columns.Add(columna.ColumnName, columna.ColumnName);
                }
            }

            DataRow nuevaFila = oDS.Tables["InformacionEquipos"].NewRow();
            oDS.Tables["InformacionEquipos"].Rows.Add(nuevaFila);

            int ultimaFila = dgvCenso.Rows.Count - 1;

            dgvCenso.CurrentCell = dgvCenso.Rows[ultimaFila].Cells[0];
            dgvCenso.BeginEdit(true);

            isNewRowBeingAdded = true; // Indicar que se est� agregando una nueva fila
            dgvCenso.ReadOnly = false; // Permitir edici�n en la nueva fila
            btnActualizar.Visible = true; // Hacer visible el bot�n de actualizar
            dgvCenso.Refresh();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;  // Inicializar la variable de conexi�n fuera del try

            try
            {
                connection = con.AbrirConexion();  // Abrir la conexi�n

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM InformacionEquipos", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(oDS, "InformacionEquipos");

                // Despu�s de actualizar, recargar los datos del ComboBox
                ConfigurarComboBox();

                // Ocultar el bot�n de actualizar y volver a establecer como solo lectura
                btnActualizar.Visible = false;
                dgvCenso.ReadOnly = true;
                dgvCenso.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                {
                    con.CerrarConexion();  // Cerrar la conexi�n en el bloque finally
                }
            }
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCenso.SelectedRows.Count > 0)

                try
                {
                    con.AbrirConexion();

                    // Iterate through selected rows and delete each one from the database
                    foreach (DataGridViewRow selectedRow in dgvCenso.SelectedRows)
                    {
                        int rowIndex = selectedRow.Index;
                        int rowID = (int)dgvCenso.Rows[rowIndex].Cells["ID"].Value;

                        // Delete from the database
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM InformacionEquipos WHERE ID = @ID", con.GetConexion()))
                        {
                            cmd.Parameters.AddWithValue("@ID", rowID);
                            cmd.ExecuteNonQuery();
                        }

                        // Remove from the DataGridView
                        dgvCenso.Rows.RemoveAt(rowIndex);
                    }

                    // Close the SqlConnection
                    con.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar registro la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con != null)
                    {
                        con.CerrarConexion();  // Cerrar la conexi�n en el bloque finally
                    }
                }
            else
            {
                MessageBox.Show("Elige una o más filas", "Ninguna fila seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void pbEditar_Click(object sender, EventArgs e)
        {
            sEditar();
        }

        private void sEditar()
        {
            if (dgvCenso.SelectedRows.Count > 0)
            {
                dgvCenso.ReadOnly = false;
                btnGuardar.Visible = true;
            }
            else
            {
                MessageBox.Show("Elige una fila para editar", "Ninguna fila seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void GuardarCambios()
        {
            SqlConnection connection = null;

            try
            {
                connection = con.AbrirConexion();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM InformacionEquipos", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(oDS, "InformacionEquipos");

                btnGuardar.Visible = false;
                dgvCenso.ReadOnly = true;
                dgvCenso.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                {
                    con.CerrarConexion();
                }
            }
        }


    }
}