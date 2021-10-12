using FrmMateria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMateria.Service
{
    interface IMateria
    {
        void Create(materia materia); // Guarda las materias.

        void Delete(materia materia); // Elimina las materias.
    }
}
