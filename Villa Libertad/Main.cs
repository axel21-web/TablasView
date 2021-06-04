using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Villa_Libertad.Complement;
using Villa_Libertad.Enums;
using Villa_Libertad.Poco;

namespace Villa_Libertad
{
    public partial class Main : Form
    {
        private Complemento complemento;
        public Main()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string NombreC = txtNombre.Text;
            int Edad = Int32.Parse(txtEdad.Text);
            string Direccion = txtDirrecion.Text;
            int index = cmbSeccion.SelectedIndex;
            Seccion seccion = (Seccion)Enum.GetValues(typeof(Seccion)).GetValue(index);

            Estudiante vpn = new Estudiante()
            {
                Nombre = NombreC,
                Edad = Edad,
                Direccion = Direccion,
                Aula = seccion,
            };

            complemento.Add(vpn);
            dgvDatos.DataSource = complemento.GetAll();
            MessageBox.Show("Se ha agregado correctamente");
        }

        private void LoadComponents()
        {
            complemento = new Complemento();
            cmbSeccion.Items.AddRange(Enum.GetValues(typeof(Seccion)).Cast<Object>().ToArray());
            cmbSeccion.SelectedIndex = 0;
            cmbSeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvDatos.ReadOnly = true;
            dgvDatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                return;
            }
            int index = dgvDatos.CurrentCell.RowIndex;
            complemento.Remove(index);
            dgvDatos.DataSource = complemento.GetAll();
        }
    }
}
