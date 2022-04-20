using ALUMNOS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALUMNOS.SERVICE
{
    interface IEstudiante
    {
        //CRUD

        //C GUARDAR
        void save(estudiante estudiante);

        //D BORRAR
        void Delete(estudiante estudiante);

    }
}
