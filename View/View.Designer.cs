namespace View
{
    partial class View
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
            grpAltaAlumno = new GroupBox();
            btnCrearAlumno = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lstAlumnosCreados = new ListBox();
            lblAlumnosCreados = new Label();
            grpAsignarMateria = new GroupBox();
            btnAsignarAlumno = new Button();
            cmbMaterias = new ComboBox();
            lblMateria = new Label();
            lstAlumnosInscriptosProgra = new ListBox();
            lblInscriptosProgra = new Label();
            lstAlumnosInscriptosLabo = new ListBox();
            lblInscriptosLabo = new Label();
            grpAltaAlumno.SuspendLayout();
            grpAsignarMateria.SuspendLayout();
            SuspendLayout();
            // 
            // grpAltaAlumno
            // 
            grpAltaAlumno.Controls.Add(btnCrearAlumno);
            grpAltaAlumno.Controls.Add(txtNombre);
            grpAltaAlumno.Controls.Add(txtApellido);
            grpAltaAlumno.Controls.Add(txtDni);
            grpAltaAlumno.Controls.Add(lblNombre);
            grpAltaAlumno.Controls.Add(lblApellido);
            grpAltaAlumno.Controls.Add(lblDni);
            grpAltaAlumno.Location = new Point(245, 22);
            grpAltaAlumno.Name = "grpAltaAlumno";
            grpAltaAlumno.Size = new Size(325, 128);
            grpAltaAlumno.TabIndex = 0;
            grpAltaAlumno.TabStop = false;
            grpAltaAlumno.Text = "Alta Alumno";
            // 
            // btnCrearAlumno
            // 
            btnCrearAlumno.Location = new Point(107, 89);
            btnCrearAlumno.Name = "btnCrearAlumno";
            btnCrearAlumno.Size = new Size(100, 23);
            btnCrearAlumno.TabIndex = 6;
            btnCrearAlumno.Text = "Crear Alumno";
            btnCrearAlumno.UseVisualStyleBackColor = true;
            btnCrearAlumno.Click += btnCrearAlumno_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(219, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(107, 48);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(6, 48);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(95, 23);
            txtDni.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(234, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(128, 30);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(63, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "APELLIDO:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(21, 30);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI:";
            // 
            // lstAlumnosCreados
            // 
            lstAlumnosCreados.FormattingEnabled = true;
            lstAlumnosCreados.ItemHeight = 15;
            lstAlumnosCreados.Location = new Point(12, 217);
            lstAlumnosCreados.Name = "lstAlumnosCreados";
            lstAlumnosCreados.Size = new Size(168, 169);
            lstAlumnosCreados.TabIndex = 1;
            // 
            // lblAlumnosCreados
            // 
            lblAlumnosCreados.AutoSize = true;
            lblAlumnosCreados.Location = new Point(12, 199);
            lblAlumnosCreados.Name = "lblAlumnosCreados";
            lblAlumnosCreados.Size = new Size(101, 15);
            lblAlumnosCreados.TabIndex = 2;
            lblAlumnosCreados.Text = "Alumnos Creados";
            // 
            // grpAsignarMateria
            // 
            grpAsignarMateria.Controls.Add(btnAsignarAlumno);
            grpAsignarMateria.Controls.Add(cmbMaterias);
            grpAsignarMateria.Controls.Add(lblMateria);
            grpAsignarMateria.Location = new Point(218, 234);
            grpAsignarMateria.Name = "grpAsignarMateria";
            grpAsignarMateria.Size = new Size(200, 152);
            grpAsignarMateria.TabIndex = 3;
            grpAsignarMateria.TabStop = false;
            grpAsignarMateria.Text = "Asignar Materia";
            // 
            // btnAsignarAlumno
            // 
            btnAsignarAlumno.Location = new Point(33, 103);
            btnAsignarAlumno.Name = "btnAsignarAlumno";
            btnAsignarAlumno.Size = new Size(121, 43);
            btnAsignarAlumno.TabIndex = 2;
            btnAsignarAlumno.Text = "Asignar al alumno seleccionado";
            btnAsignarAlumno.UseVisualStyleBackColor = true;
            btnAsignarAlumno.Click += btnAsignarAlumno_Click;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(33, 51);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(121, 23);
            cmbMaterias.TabIndex = 1;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(63, 33);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(55, 15);
            lblMateria.TabIndex = 0;
            lblMateria.Text = "MATERIA";
            // 
            // lstAlumnosInscriptosProgra
            // 
            lstAlumnosInscriptosProgra.FormattingEnabled = true;
            lstAlumnosInscriptosProgra.ItemHeight = 15;
            lstAlumnosInscriptosProgra.Location = new Point(464, 217);
            lstAlumnosInscriptosProgra.Name = "lstAlumnosInscriptosProgra";
            lstAlumnosInscriptosProgra.Size = new Size(151, 169);
            lstAlumnosInscriptosProgra.TabIndex = 4;
            // 
            // lblInscriptosProgra
            // 
            lblInscriptosProgra.AutoSize = true;
            lblInscriptosProgra.Location = new Point(464, 199);
            lblInscriptosProgra.Name = "lblInscriptosProgra";
            lblInscriptosProgra.Size = new Size(99, 15);
            lblInscriptosProgra.TabIndex = 5;
            lblInscriptosProgra.Text = "Inscriptos Progra:";
            // 
            // lstAlumnosInscriptosLabo
            // 
            lstAlumnosInscriptosLabo.FormattingEnabled = true;
            lstAlumnosInscriptosLabo.ItemHeight = 15;
            lstAlumnosInscriptosLabo.Location = new Point(637, 217);
            lstAlumnosInscriptosLabo.Name = "lstAlumnosInscriptosLabo";
            lstAlumnosInscriptosLabo.Size = new Size(151, 169);
            lstAlumnosInscriptosLabo.TabIndex = 6;
            // 
            // lblInscriptosLabo
            // 
            lblInscriptosLabo.AutoSize = true;
            lblInscriptosLabo.Location = new Point(637, 199);
            lblInscriptosLabo.Name = "lblInscriptosLabo";
            lblInscriptosLabo.Size = new Size(90, 15);
            lblInscriptosLabo.TabIndex = 7;
            lblInscriptosLabo.Text = "Inscriptos Labo:";
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInscriptosLabo);
            Controls.Add(lstAlumnosInscriptosLabo);
            Controls.Add(lblInscriptosProgra);
            Controls.Add(lstAlumnosInscriptosProgra);
            Controls.Add(grpAsignarMateria);
            Controls.Add(lblAlumnosCreados);
            Controls.Add(lstAlumnosCreados);
            Controls.Add(grpAltaAlumno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumno DIV 2C";
            Load += View_Load;
            grpAltaAlumno.ResumeLayout(false);
            grpAltaAlumno.PerformLayout();
            grpAsignarMateria.ResumeLayout(false);
            grpAsignarMateria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpAltaAlumno;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Button btnCrearAlumno;
        private ListBox lstAlumnosCreados;
        private Label lblAlumnosCreados;
        private GroupBox grpAsignarMateria;
        private ComboBox cmbMaterias;
        private Label lblMateria;
        private Button btnAsignarAlumno;
        private ListBox lstAlumnosInscriptosProgra;
        private Label lblInscriptosProgra;
        private ListBox lstAlumnosInscriptosLabo;
        private Label lblInscriptosLabo;
    }
}