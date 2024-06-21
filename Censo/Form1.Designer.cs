namespace Censo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvCenso = new DataGridView();
            comboBoxLineas = new ComboBox();
            lbl_linea = new Label();
            lbl_Censo = new Label();
            panel1 = new Panel();
            pbSalir = new PictureBox();
            pbEliminar = new PictureBox();
            pbEditar = new PictureBox();
            pbAgregar = new PictureBox();
            pictureBox4 = new PictureBox();
            btnActualizar = new Button();
            lblAviso = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCenso).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dgvCenso
            // 
            dgvCenso.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCenso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCenso.Location = new Point(53, 240);
            dgvCenso.Name = "dgvCenso";
            dgvCenso.RowHeadersWidth = 51;
            dgvCenso.RowTemplate.Height = 29;
            dgvCenso.Size = new Size(1809, 705);
            dgvCenso.TabIndex = 0;
            // 
            // comboBoxLineas
            // 
            comboBoxLineas.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxLineas.FormattingEnabled = true;
            comboBoxLineas.Location = new Point(137, 10);
            comboBoxLineas.Name = "comboBoxLineas";
            comboBoxLineas.Size = new Size(214, 36);
            comboBoxLineas.TabIndex = 1;
            // 
            // lbl_linea
            // 
            lbl_linea.AutoSize = true;
            lbl_linea.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_linea.ForeColor = Color.White;
            lbl_linea.Location = new Point(56, 11);
            lbl_linea.Name = "lbl_linea";
            lbl_linea.Size = new Size(75, 35);
            lbl_linea.TabIndex = 2;
            lbl_linea.Text = "Linea";
            // 
            // lbl_Censo
            // 
            lbl_Censo.AutoSize = true;
            lbl_Censo.Font = new Font("Myanmar Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Censo.Location = new Point(401, 43);
            lbl_Censo.Name = "lbl_Censo";
            lbl_Censo.Size = new Size(848, 50);
            lbl_Censo.TabIndex = 4;
            lbl_Censo.Text = "Censo de Software y equipos de cómputo en Líneas de Producción";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pbSalir);
            panel1.Controls.Add(pbEliminar);
            panel1.Controls.Add(pbEditar);
            panel1.Controls.Add(pbAgregar);
            panel1.Controls.Add(comboBoxLineas);
            panel1.Controls.Add(lbl_linea);
            panel1.Location = new Point(-5, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(2022, 56);
            panel1.TabIndex = 5;
            // 
            // pbSalir
            // 
            pbSalir.BackgroundImage = (Image)resources.GetObject("pbSalir.BackgroundImage");
            pbSalir.Cursor = Cursors.Hand;
            pbSalir.Location = new Point(1818, 3);
            pbSalir.Margin = new Padding(0);
            pbSalir.Name = "pbSalir";
            pbSalir.Size = new Size(47, 46);
            pbSalir.TabIndex = 7;
            pbSalir.TabStop = false;
            pbSalir.MouseLeave += pbSalir_MouseLeave;
            pbSalir.MouseHover += pbSalir_MouseHover;
            // 
            // pbEliminar
            // 
            pbEliminar.BackgroundImage = (Image)resources.GetObject("pbEliminar.BackgroundImage");
            pbEliminar.Cursor = Cursors.Hand;
            pbEliminar.Location = new Point(1638, 3);
            pbEliminar.Margin = new Padding(0);
            pbEliminar.Name = "pbEliminar";
            pbEliminar.Size = new Size(47, 46);
            pbEliminar.TabIndex = 6;
            pbEliminar.TabStop = false;
            pbEliminar.Click += pbEliminar_Click;
            pbEliminar.MouseLeave += pbEliminar_MouseLeave;
            pbEliminar.MouseHover += pbEliminar_MouseHover;
            // 
            // pbEditar
            // 
            pbEditar.BackgroundImage = (Image)resources.GetObject("pbEditar.BackgroundImage");
            pbEditar.Cursor = Cursors.Hand;
            pbEditar.Location = new Point(1699, 3);
            pbEditar.Margin = new Padding(0);
            pbEditar.Name = "pbEditar";
            pbEditar.Size = new Size(47, 46);
            pbEditar.TabIndex = 5;
            pbEditar.TabStop = false;
            pbEditar.Click += pbEditar_Click;
            pbEditar.MouseLeave += pbEditar_MouseLeave;
            pbEditar.MouseHover += pbEditar_MouseHover;
            // 
            // pbAgregar
            // 
            pbAgregar.BackgroundImage = (Image)resources.GetObject("pbAgregar.BackgroundImage");
            pbAgregar.Cursor = Cursors.Hand;
            pbAgregar.Location = new Point(1760, 3);
            pbAgregar.Margin = new Padding(0);
            pbAgregar.Name = "pbAgregar";
            pbAgregar.Size = new Size(47, 46);
            pbAgregar.TabIndex = 4;
            pbAgregar.TabStop = false;
            pbAgregar.Click += pbAgregar_Click;
            pbAgregar.MouseLeave += pbAgregar_MouseLeave;
            pbAgregar.MouseHover += pbAgregar_MouseHover;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Location = new Point(20, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(226, 84);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Indigo;
            btnActualizar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(1697, 43);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(108, 34);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAviso.Location = new Point(20, 127);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(55, 24);
            lblAviso.TabIndex = 8;
            lblAviso.Text = "Aviso";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Indigo;
            btnGuardar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(1555, 43);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 34);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1924, 976);
            Controls.Add(btnGuardar);
            Controls.Add(lblAviso);
            Controls.Add(btnActualizar);
            Controls.Add(pictureBox4);
            Controls.Add(lbl_Censo);
            Controls.Add(dgvCenso);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Sensience";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCenso).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCenso;
        private ComboBox comboBoxLineas;
        private Label lbl_linea;
        private Label lbl_Censo;
        private Panel panel1;
        private PictureBox pbAgregar;
        private PictureBox pbSalir;
        private PictureBox pbEliminar;
        private PictureBox pbEditar;
        private PictureBox pictureBox4;
        private Button btnActualizar;
        private Label lblAviso;
        private Button btnGuardar;
    }
}