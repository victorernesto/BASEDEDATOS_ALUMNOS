using ALUMNOS.DATA;
using ALUMNOS.SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALUMNOS.REPOSITORY
{
    class ClsREstudiante : IEstudiante
    {
        public void Delete(estudiante estudiante)
        {

            using (EstudiantesEntities conexionbd =new EstudiantesEntities())
            {
                try {
                    estudiante est = new estudiante();
                    est.nombresEstudiante = estudiante.nombresEstudiante;
                    est.apellidos = estudiante.apellidos;
                    est.usuario = estudiante.usuario;
                    est.contrasenia = estudiante.contrasenia;
                    conexionbd.estudiante.Add(est);
                    conexionbd.SaveChanges();
                    MessageBox.Show("SE GUARDO");
                } catch (Exception ex){
                    MessageBox.Show("error de base de datos"+ex);

                }
            }
        }

        public void save(estudiante estudiante)
        {
            
        }
    }
}
