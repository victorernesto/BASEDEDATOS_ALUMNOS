using ALUMNOS.DATA;
using ALUMNOS.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALUMNOS.VISTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            estudiante es = new estudiante();
            es.nombresEstudiante = txtnombre.Text;
            es.apellidos = txtapellidos.Text;
            es.usuario = txtusuario.Text;
            es.contrasenia = txtcontraseña.Text;
            Clsalumno clsalumno = new Clsalumno();
            clsalumno.GUARDAR(es);
            clsalumno.Delete(es);
        }
    }
}
