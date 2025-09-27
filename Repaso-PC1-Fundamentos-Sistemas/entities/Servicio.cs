using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_PC1_Fundamentos_Sistemas.entities
{
    internal class Servicio
    {
        //Constructor Servicio
        public Servicio() { }
        //Codigo
        public string Codigo { get; set; }
        //Nombre
        public string Nombre { get; set; }
        //Categoria
        public string Categoria { get; set; }
        //Costo
        public double Costo { get; set; }
    }
}
