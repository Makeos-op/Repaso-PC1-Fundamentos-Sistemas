using Repaso_PC1_Fundamentos_Sistemas.entities;
using Repaso_PC1_Fundamentos_Sistemas.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_PC1_Fundamentos_Sistemas
{
    public partial class FormAlmacen : Form
    {
        private AlmacenService almacenService = new AlmacenService();
        public FormAlmacen()
        {
            InitializeComponent();
            MostrarAlmacenes(AlmacenService.ListarAlmacenes());
        }
        private void MostrarAlmacenes (List<Almacen> Almacenes)
        {
            dgAlmancen.DataSource= null;
            if (Almacenes.Count() == 0)
            {
                return;
            }
            dgAlmancen.DataSource = Almacenes;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == "" || cbTipo.SelectedItem == null || tbCapacidad.Text== "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            Almacen almacen = new Almacen()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Tipo = cbTipo.SelectedItem.ToString(),
                Capacidad = int.Parse(tbCapacidad.Text),
                Servicios = new List<Servicio>()
            };
            bool registrado = almacenService.Registrar(almacen);
            if (!registrado)
            {
                MessageBox.Show("Almacen ya existente");
                return;
            }
            MostrarAlmacenes(AlmacenService.ListarAlmacenes());
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerServicios_Click(object sender, EventArgs e)
        {
            if (dgAlmancen.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una Fila");
                return;
            }
            string codigoAlmacen = dgAlmancen.SelectedRows[0].Cells["Codigo"].Value.ToString();
            FormServicio form = new FormServicio(codigoAlmacen);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
