using FrmMateria.Data;
using FrmMateria.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMateria.Repository
{
    class ClsRMateria : IMateria
    {
        public void Create(materia materia)
        {
            // conexionBd: Mantiene la conexion con la base de datos.
            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                try
                {
                    // est: Almacena una coleccion de datos (nombre)
                    materia mat = new materia();
                    mat.nombreMateria = materia.nombreMateria;

                    conexionBd.materia.Add(mat);
                    conexionBd.SaveChanges(); //Para guardar los cambios.
                    MessageBox.Show("Guardado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos" + ex);
                }
            }
        }

        public void Delete(materia materia)
        {
            
        }
    }
}
