using System.Data;
using System.Data.SqlClient;

namespace Censo
{
    internal class Conexion
    {
        private SqlConnection conexion;

        public Conexion()
        {
            try
            {
                // No es necesario abrir la conexión en el constructor
                conexion = new SqlConnection("Data Source=DESKTOP-5GVNUF2; Initial Catalog=Censo; Integrated Security=True;");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para abrir la conexión
        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
            }
            catch (Exception ex)
            {
                // Lanza una excepción en lugar de mostrar un MessageBox
                throw new Exception("Error al abrir la conexión", ex);
            }

            return conexion;
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                // Lanza una excepción en lugar de mostrar un MessageBox
                throw new Exception("Error al cerrar la conexión", ex);
            }
        }

        // Método para obtener la conexión
        public SqlConnection GetConexion()
        {
            return conexion;
        }
    }
}
