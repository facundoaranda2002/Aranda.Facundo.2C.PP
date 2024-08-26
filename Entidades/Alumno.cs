using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private string legajo;
        private Dictionary<EMateria, List<int>> materiasAsignadas;


        public override string Informacion
        {
            get
            {
                return $"Alumno - {this.MostrarDatos()}";
            }
        }

        public List<int> this[EMateria materia]
        {
            get
            {
                if(this==materia)
                {
                    return this.materiasAsignadas[materia];
                }
                return null;
            }
        }

        private Alumno(int dni) : base(dni)
        {
            materiasAsignadas = new Dictionary<EMateria, List<int>>();
        }

        public Alumno(int dni, string legajo) : this(dni)
        {
            this.legajo = legajo;
        }

        public bool RendirExamen(EMateria materia)
        {
            if(this == materia)
            {
                Random random = new Random();
                this.materiasAsignadas[materia].Add(random.Next(1, 11));
                return true;
            }
            return false;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine("Materias: ");
            foreach(EMateria m in this.materiasAsignadas.Keys)
            {
                sb.AppendLine(m.ToString());
            }
            return sb.ToString();
        }

        public static implicit operator Alumno(string dni)
        {
            int dniEntero = int.Parse(dni);
            Alumno a = new Alumno(dniEntero);
            a.legajo = $"L-{a.GetHashCode()}";
            return a;
        }

        public static bool operator ==(Alumno alumno, EMateria materia)
        {
            return alumno.materiasAsignadas.ContainsKey(materia);
        }

        public static bool operator !=(Alumno alumno, EMateria materia)
        {
            return !(alumno == materia);
        }

        public static bool operator +(Alumno alumno, EMateria materia)
        {
            if (alumno!=materia)
            {
                alumno.materiasAsignadas.Add(materia, new List<int>());
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Alumno - {this.legajo}";
        }
    }
}
