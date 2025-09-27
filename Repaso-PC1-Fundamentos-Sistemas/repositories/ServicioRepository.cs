using Repaso_PC1_Fundamentos_Sistemas.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_PC1_Fundamentos_Sistemas.repositories
{
    internal class ServicioRepository
    {
        //Verificar si existe
        public bool Existe(string CodigoServicio)
        {
            List<Almacen> almacenes = AlmacenRepository.ListarAlmacenes();
            return almacenes.Exists(a => a.Servicios.Exists(b => b.Codigo.Equals(CodigoServicio)));
        }
        public void RegistrarCancion(string CodigoAlmacen, Servicio servicio)
        {
            List<Almacen> almacenes = AlmacenRepository.ListarAlmacenes();
            Almacen almacen = almacenes.Find(a => a.Codigo.Equals(CodigoAlmacen));
            almacen.Servicios.Add(servicio);
        }
    }
}
