namespace Practica1erParcialLab3
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
            components = new System.ComponentModel.Container();
            dgAlumnos = new DataGridView();
            alumnoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            legajoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            alumnosBindingSource3 = new BindingSource(components);
            materiasBindingSource = new BindingSource(components);
            alumnosBindingSource2 = new BindingSource(components);
            alumnosBindingSource1 = new BindingSource(components);
            alumnosBindingSource = new BindingSource(components);
            dgMaterias = new DataGridView();
            materiaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            labelMateria = new Label();
            labelAlumno = new Label();
            label1 = new Label();
            label2 = new Label();
            btnBuscaPorMateria = new Button();
            btnBuscaPorAlumno = new Button();
            txtBusqueda = new TextBox();
            label3 = new Label();
            txtInformacionFila = new TextBox();
            txtCantidadMaterias = new TextBox();
            txtCantidadAlumnos = new TextBox();
            lblCtdAlumnos = new Label();
            lblCantidadMaterias = new Label();
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materiasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMaterias).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgAlumnos
            // 
            dgAlumnos.AllowUserToAddRows = false;
            dgAlumnos.AllowUserToDeleteRows = false;
            dgAlumnos.AllowUserToOrderColumns = true;
            dgAlumnos.AutoGenerateColumns = false;
            dgAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlumnos.Columns.AddRange(new DataGridViewColumn[] { alumnoIDDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, legajoDataGridViewTextBoxColumn, Nota });
            dgAlumnos.DataSource = alumnosBindingSource3;
            dgAlumnos.Dock = DockStyle.Fill;
            dgAlumnos.Location = new Point(0, 0);
            dgAlumnos.Name = "dgAlumnos";
            dgAlumnos.RowTemplate.Height = 25;
            dgAlumnos.Size = new Size(558, 355);
            dgAlumnos.TabIndex = 0;
            dgAlumnos.CellClick += dgAlumnos_CellClick;
            // 
            // alumnoIDDataGridViewTextBoxColumn
            // 
            alumnoIDDataGridViewTextBoxColumn.DataPropertyName = "_alumnoID";
            alumnoIDDataGridViewTextBoxColumn.HeaderText = "Alumno";
            alumnoIDDataGridViewTextBoxColumn.Name = "alumnoIDDataGridViewTextBoxColumn";
            alumnoIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "_apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.Width = 76;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "_nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 76;
            // 
            // legajoDataGridViewTextBoxColumn
            // 
            legajoDataGridViewTextBoxColumn.DataPropertyName = "legajo";
            legajoDataGridViewTextBoxColumn.HeaderText = "Legajo";
            legajoDataGridViewTextBoxColumn.Name = "legajoDataGridViewTextBoxColumn";
            legajoDataGridViewTextBoxColumn.Width = 67;
            // 
            // Nota
            // 
            Nota.DataPropertyName = "_nota";
            Nota.HeaderText = "Nota";
            Nota.Name = "Nota";
            Nota.Width = 58;
            // 
            // alumnosBindingSource3
            // 
            alumnosBindingSource3.DataMember = "_alumnos";
            alumnosBindingSource3.DataSource = materiasBindingSource;
            // 
            // materiasBindingSource
            // 
            materiasBindingSource.DataSource = typeof(Materias_Alumnos.Materias);
            // 
            // alumnosBindingSource2
            // 
            alumnosBindingSource2.DataMember = "_alumnos";
            alumnosBindingSource2.DataSource = materiasBindingSource;
            // 
            // alumnosBindingSource1
            // 
            alumnosBindingSource1.DataMember = "_alumnos";
            alumnosBindingSource1.DataSource = materiasBindingSource;
            // 
            // alumnosBindingSource
            // 
            alumnosBindingSource.DataMember = "_alumnos";
            alumnosBindingSource.DataSource = materiasBindingSource;
            // 
            // dgMaterias
            // 
            dgMaterias.AllowUserToAddRows = false;
            dgMaterias.AllowUserToDeleteRows = false;
            dgMaterias.AllowUserToOrderColumns = true;
            dgMaterias.AutoGenerateColumns = false;
            dgMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMaterias.Columns.AddRange(new DataGridViewColumn[] { materiaIdDataGridViewTextBoxColumn });
            dgMaterias.DataSource = materiasBindingSource;
            dgMaterias.Dock = DockStyle.Fill;
            dgMaterias.Location = new Point(0, 0);
            dgMaterias.Name = "dgMaterias";
            dgMaterias.Size = new Size(212, 355);
            dgMaterias.TabIndex = 1;
            dgMaterias.CellClick += dgMaterias_CellClick;
            dgMaterias.SelectionChanged += dgMaterias_SelectionChanged;
            // 
            // materiaIdDataGridViewTextBoxColumn
            // 
            materiaIdDataGridViewTextBoxColumn.DataPropertyName = "_materiaId";
            materiaIdDataGridViewTextBoxColumn.HeaderText = "Materia";
            materiaIdDataGridViewTextBoxColumn.Name = "materiaIdDataGridViewTextBoxColumn";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(37, 108);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(212, 42);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar Datos";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dgMaterias);
            panel1.Location = new Point(37, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 355);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgAlumnos);
            panel2.Location = new Point(329, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 355);
            panel2.TabIndex = 4;
            // 
            // labelMateria
            // 
            labelMateria.AutoSize = true;
            labelMateria.Location = new Point(47, 523);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(50, 15);
            labelMateria.TabIndex = 5;
            labelMateria.Text = "Materia:";
            // 
            // labelAlumno
            // 
            labelAlumno.AutoSize = true;
            labelAlumno.Location = new Point(329, 523);
            labelAlumno.Name = "labelAlumno";
            labelAlumno.Size = new Size(53, 15);
            labelAlumno.TabIndex = 6;
            labelAlumno.Text = "Alumno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 523);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 523);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            // 
            // btnBuscaPorMateria
            // 
            btnBuscaPorMateria.Location = new Point(329, 74);
            btnBuscaPorMateria.Name = "btnBuscaPorMateria";
            btnBuscaPorMateria.Size = new Size(127, 34);
            btnBuscaPorMateria.TabIndex = 9;
            btnBuscaPorMateria.Text = "Buscar por Materia";
            btnBuscaPorMateria.UseVisualStyleBackColor = true;
            btnBuscaPorMateria.Click += btnBuscaPorMateria_Click;
            // 
            // btnBuscaPorAlumno
            // 
            btnBuscaPorAlumno.Location = new Point(329, 115);
            btnBuscaPorAlumno.Name = "btnBuscaPorAlumno";
            btnBuscaPorAlumno.Size = new Size(127, 35);
            btnBuscaPorAlumno.TabIndex = 10;
            btnBuscaPorAlumno.Text = "Busca por Alumno";
            btnBuscaPorAlumno.UseVisualStyleBackColor = true;
            btnBuscaPorAlumno.Click += btnBuscaPorAlumno_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(476, 96);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(140, 23);
            txtBusqueda.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(694, 43);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 12;
            label3.Text = "Resultado de busqueda:";
            // 
            // txtInformacionFila
            // 
            txtInformacionFila.Location = new Point(694, 64);
            txtInformacionFila.Multiline = true;
            txtInformacionFila.Name = "txtInformacionFila";
            txtInformacionFila.Size = new Size(255, 72);
            txtInformacionFila.TabIndex = 13;
            // 
            // txtCantidadMaterias
            // 
            txtCantidadMaterias.Location = new Point(146, 43);
            txtCantidadMaterias.Name = "txtCantidadMaterias";
            txtCantidadMaterias.Size = new Size(99, 23);
            txtCantidadMaterias.TabIndex = 14;
            // 
            // txtCantidadAlumnos
            // 
            txtCantidadAlumnos.Location = new Point(146, 81);
            txtCantidadAlumnos.Name = "txtCantidadAlumnos";
            txtCantidadAlumnos.Size = new Size(99, 23);
            txtCantidadAlumnos.TabIndex = 15;
            // 
            // lblCtdAlumnos
            // 
            lblCtdAlumnos.AutoSize = true;
            lblCtdAlumnos.Location = new Point(37, 84);
            lblCtdAlumnos.Name = "lblCtdAlumnos";
            lblCtdAlumnos.Size = new Size(106, 15);
            lblCtdAlumnos.TabIndex = 16;
            lblCtdAlumnos.Text = "Cantidad Alumnos";
            // 
            // lblCantidadMaterias
            // 
            lblCantidadMaterias.AutoSize = true;
            lblCantidadMaterias.Location = new Point(37, 46);
            lblCantidadMaterias.Name = "lblCantidadMaterias";
            lblCantidadMaterias.Size = new Size(103, 15);
            lblCantidadMaterias.TabIndex = 17;
            lblCantidadMaterias.Text = "Cantidad Materias";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 597);
            Controls.Add(lblCantidadMaterias);
            Controls.Add(lblCtdAlumnos);
            Controls.Add(txtCantidadAlumnos);
            Controls.Add(txtCantidadMaterias);
            Controls.Add(txtInformacionFila);
            Controls.Add(label3);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscaPorAlumno);
            Controls.Add(btnBuscaPorMateria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelAlumno);
            Controls.Add(labelMateria);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBuscar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)materiasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMaterias).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgAlumnos;
        private DataGridView dgMaterias;
        private Button btnBuscar;
        private Panel panel1;
        private Panel panel2;
        private BindingSource alumnosBindingSource;
        private BindingSource materiasBindingSource;
        private DataGridViewTextBoxColumn materiaIdDataGridViewTextBoxColumn;
        private BindingSource alumnosBindingSource1;
        private BindingSource alumnosBindingSource2;
        private Label labelMateria;
        private Label labelAlumno;
        private Label label1;
        private Label label2;
        private Button btnBuscaPorMateria;
        private Button btnBuscaPorAlumno;
        private TextBox txtBusqueda;
        private DataGridViewTextBoxColumn alumnoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn legajoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Nota;
        private BindingSource alumnosBindingSource3;
        private Label label3;
        private TextBox txtInformacionFila;
        private TextBox txtCantidadMaterias;
        private TextBox txtCantidadAlumnos;
        private Label lblCtdAlumnos;
        private Label lblCantidadMaterias;
    }
}