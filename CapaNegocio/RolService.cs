using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class RolService
    {

        private RolRepository objcd_rol = new RolRepository();


        public List<Rol> Listar()
        {
            return objcd_rol.Listar();
        }
    }
}
