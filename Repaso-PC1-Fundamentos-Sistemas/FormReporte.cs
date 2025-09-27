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
    public partial class FormReporte : Form
    {
        private AlmacenService almacenService = new AlmacenService();
        private ServicioService servicioService = new ServicioService();

        public FormReporte()
        {
            InitializeComponent();

        }
        private void MostrarAlmacenes(List <Almacen> almacenes)
        {
            dgAlmancen.DataSource = null;
            if (almacenes.Count() == 0)
            {
                return;
            }
            dgAlmancen.DataSource = almacenes;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlmacenSinServicios_Click(object sender, EventArgs e)
        {
            MostrarAlmacenes(almacenService.ListarAlmacenessinServicios());
        }

        private void btnAlmacenes_por_tipo_Click(object sender, EventArgs e)
        {
            string valor_elegido = cbTipo.SelectedItem.ToString();
            MostrarAlmacenes(almacenService.ListarAlmacenesDelMismoTipo(valor_elegido));
        }
    }
}
