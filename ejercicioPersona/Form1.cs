using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona1 = new Persona(50, "Luis");
            MessageBox.Show(persona1.ToString());
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno1 = new Alumno(21, "Que", 4, 3);
            alumno1.SetCurso(2);
            MessageBox.Show(alumno1.ToString());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado(43, "Que", 2020, "Que", 3.0E5m);
            MessageBox.Show(empleado1.ToString());
        }
    }
}