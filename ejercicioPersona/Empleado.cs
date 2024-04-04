using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPersona
{
    internal class Empleado : Persona
    {
        private int añoIngreso;
        private string sector;
        private decimal sueldo;

        public int AñoIngreso
        {
            get { return añoIngreso; }
            set { añoIngreso = value; }
        }
        public string Sector
        {
            get { return sector; }
            set { sector = value; }
        }
        public decimal Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public Empleado(int pEdad, string pNombre, int pAñoIngreso, string pSector, decimal pSueldo):base(pEdad, pNombre)
        {
            AñoIngreso = pAñoIngreso;
            Sector = pSector;
            Sueldo = pSueldo;
        }
        public int Antiguedad()
        {
            return DateTime.Now.Year - AñoIngreso;
        }
        public override string ToString()
        {
            return base.ToString() + "\nAño de ingreso: " + AñoIngreso + "\nSector: " + Sector + "\nSueldo: " + Sueldo + "\nAntiguedad: " + Antiguedad();
        }
    }
}