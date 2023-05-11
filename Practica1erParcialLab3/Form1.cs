using Materias_Alumnos;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica1erParcialLab3
{

    public partial class Form1 : Form
    {
        private List<Materias> _listaMaterias = new List<Materias>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtCantidadMaterias.Text);
            int j = Convert.ToInt32(txtCantidadAlumnos.Text);
            // Generar la lista de materias y alumnos
            var generador = new Generador();
            _listaMaterias = generador.GenerarAlumnos(i, j);

            // Mostrar la lista de materias en el DataGridView dgMaterias
            dgMaterias.DataSource = _listaMaterias;
            dgMaterias.AutoGenerateColumns = true;

        }

        private void dgMaterias_SelectionChanged(object sender, EventArgs e)
        {

            if (dgMaterias.CurrentRow != null)
            {
                var materiaSeleccionada = (Materias)dgMaterias.CurrentRow.DataBoundItem;
                dgAlumnos.DataSource = materiaSeleccionada._alumnos;
            }
            //dgAlumnos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgAlumnos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgAlumnos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgAlumnos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dgMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var txt = e.RowIndex;
            if (txt != -1)
            {
                label1.Text = (string)dgMaterias.Rows[txt].Cells[0].Value;
            }


        }

        private void dgAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var txt = e.RowIndex;
            if (txt != -1)
            {
                var u = dgAlumnos.Rows[txt].Cells[0].Value;
                var y = dgAlumnos.Rows[txt].Cells[1].Value;
                var t = dgAlumnos.Rows[txt].Cells[2].Value;
                var r = dgAlumnos.Rows[txt].Cells[3].Value;
                label2.Text = $"{u.ToString()}, {y.ToString()}, {t.ToString()}. {r.ToString()}";
            }
        }

        private void btnBuscaPorMateria_Click(object sender, EventArgs e)
        {
            var nombre = txtBusqueda.Text;

            foreach (DataGridViewRow a in dgMaterias.Rows)
            {
                var nombremateria = a.Cells[0].Value.ToString();
                if (nombremateria.ToLower().Contains(nombre.ToLower()))
                {
                    a.Selected = true;
                    dgMaterias.CurrentCell = a.Cells[0];
                    break;
                }
            }
        }

        //private void btnBuscaPorAlumno_Click(object sender, EventArgs e)
        //{
        //    var nombre = txtBusqueda.Text;

        //    foreach (DataGridViewRow a in dgAlumnos.Rows)
        //    {
        //        var nombreAlumno = a.Cells[0].Value.ToString();
        //        if (nombreAlumno.ToLower().Contains(nombre.ToLower()))
        //        {
        //            a.Selected = true;
        //            dgAlumnos.CurrentCell = a.Cells[0];

        //            // Obtener la fila actualmente seleccionada
        //            DataGridViewRow filaActual = dgAlumnos.CurrentRow;

        //            // Verificar si la fila actual es nula
        //            if (filaActual != null)
        //            {
        //                // Crear una cadena de texto con los valores de cada celda de la fila
        //                string informacionFila = "";
        //                foreach (DataGridViewCell celda in filaActual.Cells)
        //                {
        //                    informacionFila += celda.Value.ToString() + " | ";
        //                }

        //                // Mostrar la información en un cuadro de texto distinto a txtBusqueda
        //                txtInformacionFila.Text = informacionFila;
        //            }

        //            break;
        //        }
        //    }
        //}

        private void btnBuscaPorAlumno_Click(object sender, EventArgs e)
        {
            string nombre = txtBusqueda.Text;
            foreach (DataGridViewRow row in dgAlumnos.Rows)
            {
                string nombreAlumno = row.Cells[2].Value.ToString();

                if (nombreAlumno.ToLower().Contains(nombre.ToLower()))
                {
                    row.Selected = true;
                    dgAlumnos.CurrentCell = row.Cells[2];

                    // Obtener el índice de la fila seleccionada
                    int indiceFilaSeleccionada = row.Index;

                    // Obtener la información que deseas mostrar y asignarla al TextBox
                    if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < dgAlumnos.Rows.Count)
                    {
                        DataGridViewRow filaSeleccionada = dgAlumnos.Rows[indiceFilaSeleccionada];
                        var detalle = $"{filaSeleccionada.Cells[0].Value.ToString()}\r\n{filaSeleccionada.Cells[1].Value.ToString()}\r\n{filaSeleccionada.Cells[2].Value.ToString()}\r\n{filaSeleccionada.Cells[3].Value.ToString()}";
                        txtInformacionFila.Text = detalle;
                    }

                    break;
                }
            }
            //    var nombre = txtBusqueda.Text;

            //    foreach (DataGridViewRow a in dgAlumnos.Rows)
            //    {
            //        var nombreAlumno = a.Cells[0].Value.ToString();
            //        if (nombreAlumno.ToLower().Contains(nombre.ToLower()))
            //        {
            //            a.Selected = true;
            //            dgAlumnos.CurrentCell = a.Cells[0];

            //            break;
            //        }
            //    }
            //}


            //private void dgAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
            //{
            //    if (e.RowIndex is not -1)
            //    {
            //        var (u, y, t, r) = dgAlumnos.Rows[e.RowIndex].Cells
            //            .Cast<DataGridViewCell>()
            //            .Select(cell => cell.Value?.ToString() ?? string.Empty)
            //            .ToArray();

            //        label2.Text = $"{u}, {y}, {t}. {r}";
            //    }
            //}
        }
    }
}