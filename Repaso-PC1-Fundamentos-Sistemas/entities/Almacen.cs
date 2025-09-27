using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_PC1_Fundamentos_Sistemas.entities
{
    internal class Almacen
    {
        public Almacen() { }
        //Codigo
        public string Codigo { get; set; }
        //Nombre
        public string Nombre { get; set; }
        //Tipo
        public string Tipo { get; set; }
        //Capacidad en kg
        public int Capacidad { get; set; }
        public List<Servicio> Servicios { get; set; }
    }
}
