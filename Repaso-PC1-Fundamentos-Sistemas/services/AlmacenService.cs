using Repaso_PC1_Fundamentos_Sistemas.entities;
using Repaso_PC1_Fundamentos_Sistemas.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_PC1_Fundamentos_Sistemas.services
{
    internal class AlmacenService
    {
        private AlmacenRepository almacenRepository = new AlmacenRepository();
        bool Registrar(Almacen Almacen)
        {
            if (almacenRepository.ExisteAlmacen(Almacen.Codigo))
            {
                return false;
            }
            almacenRepository.RegistrarAlmacen (Almacen);
            return true;
        }
        public static List<Almacen> ListarAlmacenes()
        {
           return AlmacenRepository.ListarAlmacenes();
        }
        public List<Almacen> ListarAlmacenesDelMismoTipo(string Tipo)
        {
            return almacenRepository.ListarAlmacenesDelMismoTipo(Tipo);
        }
        public List<Almacen> ListarAlmacenessinServicios()
        {
            return almacenRepository.ListarAlmacenessinServicios();
        }
    }
}
