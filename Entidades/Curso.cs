using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Persona> alumnos;
        private EMateria materia;
        private Persona profesor;


        public Profesor Profesor { get => (Profesor)profesor; set => profesor = value; }
        public List<Persona> Alumnos { get => alumnos; }

        public Curso(Profesor profesor)
        {
            this.Profesor = profesor;
            this.materia = profesor.MateriaAsignada;
            this.alumnos = new List<Persona>();
        }

        public string InscribirAlumno(Alumno alumno)
        {
            if (this != alumno && alumno + this.materia)
            {
                this.alumnos.Add(alumno);
                return $"Se inscribio al alumno a la materia {this.materia.ToString()}\n{alumno.ToString()}";
            }
            return $"Ya inscripto o no se pudo inscribir el alumno a la materia {this.materia}";
        }

        public static void EvaluarAlumnos(Curso curso)
        {
            foreach (Alumno a in curso.Alumnos)
            {
                if(((Profesor)curso.Profesor).Evaluar(a))
                a.RendirExamen(curso.materia);
            }
        }

        public static string MostrarInformacionDelCurso(Curso curso)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Materia: {curso.materia}");
            sb.AppendLine($"Profesor: {curso.Profesor}");
            sb.AppendLine($"Alumnos");
            foreach (Alumno a in curso.Alumnos)
            {
                sb.AppendLine($"{a.ToString()}");
            }
            return sb.ToString();
        }

        public static bool operator ==(Curso curso, Alumno alumno)
        {
            return curso.alumnos.Contains(alumno);
        }

        public static bool operator !=(Curso curso, Alumno alumno)
        {
            return !(curso == alumno);
        }

        public override string ToString()
        {
            return $"Curso de {this.materia}";
        }

    }
}
