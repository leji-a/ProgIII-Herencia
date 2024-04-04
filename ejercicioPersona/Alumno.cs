using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPersona
{
    internal class Alumno : Persona
    {
        private int curso;
        private int nivelAcademico;

        public int Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public int NivelAcademico
        {
            get { return nivelAcademico; }
            set { nivelAcademico = value; }
        }

        public Alumno(int pEdad, string pNombre, int pCurso, int pNivelAcademico) : base(pEdad, pNombre)
        {
            Curso = pCurso;
            NivelAcademico = pNivelAcademico;
        }

        public void SetCurso(int pCurso)
        {
            Curso = pCurso;
        }
        public override string ToString()
        {
            return base.ToString() + "\nCurso: " + Curso + "\nNivel academico: " + NivelAcademico;
        }
    }
}