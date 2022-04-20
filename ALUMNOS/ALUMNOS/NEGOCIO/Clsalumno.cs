using ALUMNOS.DATA;
using ALUMNOS.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALUMNOS.NEGOCIO
{
    class Clsalumno : ClsREstudiante
    {
        public void GUARDAR(estudiante es){

            Delete(es);
        }
    }
}
