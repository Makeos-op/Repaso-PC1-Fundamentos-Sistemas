using Repaso_PC1_Fundamentos_Sistemas.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_PC1_Fundamentos_Sistemas.repositories
{
    internal class AlmacenRepository
    {
        //Lista de Almacenes
        private static List<Almacen> Almacenes = new List<Almacen>();
        //Verificar si existe un almacen
        public bool ExisteAlmacen(string codigo)
        {
            return Almacenes.Exists(a => a.Codigo.Equals(codigo));
        }
        //Registrar Almacen
        public void RegistrarAlmacen(Almacen Almacen)
        {
            Almacenes.Add(Almacen);
        }
        //Mostrar todos los almacenes
        public static List<Almacen> ListarAlmacenes()
        {
            return Almacenes;
        }
        public List<Almacen> ListarAlmacenesDelMismoTipo(string Tipo)
        {
            return Almacenes.Where(a => a.Tipo.Equals(Tipo)).ToList();
        }
        public List<Almacen> ListarAlmacenessinServicios()
        {
            return Almacenes.Where(a=>a.Servicios.Count()== 0).ToList();
        }
    }
}
