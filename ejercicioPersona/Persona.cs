using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPersona
{
    internal class Persona
    {
        private int edad;
        private string nombre;

        public int Edad
        {
            get { return edad; } set { edad = value; }
        }
        public string Nombre
        {
            get { return nombre; } set { nombre = value; }
        }

        public Persona(int pEdad, string pNombre)
        {
            Edad = pEdad;
            Nombre = pNombre;
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + "\nEdad: " + Edad;
        }
    }
}