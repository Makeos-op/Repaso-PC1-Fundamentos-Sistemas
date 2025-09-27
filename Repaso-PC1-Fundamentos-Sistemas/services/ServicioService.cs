using Repaso_PC1_Fundamentos_Sistemas.entities;
using Repaso_PC1_Fundamentos_Sistemas.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_PC1_Fundamentos_Sistemas.services
{
    internal class ServicioService
    {
        private ServicioRepository servicioRepository = new ServicioRepository();
        public bool Registrar(string codigoAlbum, Servicio servicio)
        {
            if (servicioRepository.Existe(servicio.Codigo))
            {
                return false;
            }
            servicioRepository.RegistrarCancion(codigoAlbum, servicio);
            return true;
        }
        public static List<Servicio> ListarTodoDelAlbum(string codigoalbum)
        {
            return ServicioRepository.ListarServiciosenAlmacen(codigoalbum);
        }
    }
}
