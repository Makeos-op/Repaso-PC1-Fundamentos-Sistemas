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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Repaso_PC1_Fundamentos_Sistemas
{
    public partial class FormServicio : Form
    {
        private ServicioService servicioService = new ServicioService();
        private string CodigoAlmacen;
        private void MostrarServicio(List<Servicio> servicios) 
        {
            dgAlmancen.DataSource = null;
            if (servicios.Count == 0)
            {
                return;
            }
            dgAlmancen.DataSource = servicios;
        }
        public FormServicio(string codigo)
        {
            InitializeComponent();
            this.CodigoAlmacen = codigo;
            MostrarServicio(ServicioService.ListarTodoDelAlbum(CodigoAlmacen));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == "" || cbCategoria.SelectedItem == null || tbCapacidad.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            Servicio servicio = new Servicio()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Categoria = cbCategoria.SelectedItem.ToString(),
                Costo = int.Parse(tbCapacidad.Text),
            };
            bool registrado = servicioService.Registrar(CodigoAlmacen,servicio);
            if (!registrado)
            {
                MessageBox.Show("Almacen ya existente");
                return;
            }
            MostrarServicio(ServicioService.ListarTodoDelAlbum(CodigoAlmacen));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
