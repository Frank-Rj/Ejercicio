using FrmMateria.Data;
using FrmMateria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMateria.Negocio
{
    class ClsMateria : ClsRMateria
    {
        public void Guardar(materia mt)
        {
            Create(mt);
        }
    }
}
