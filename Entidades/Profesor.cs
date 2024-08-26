using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private string email;
        private EMateria materiaAsignada;

        public EMateria MateriaAsignada { get => materiaAsignada; set => materiaAsignada = value; }
        public override string Informacion
        {
            get
            {
                return $"Profesor - {this.MostrarDatos()}";
            }
        }

        public Profesor(int dni):base(dni)
        {

        }

        public Profesor(int dni, string email) : this(dni)
        {
            this.email = email;
        }

        public Profesor(int dni, string email, EMateria materiaAsignada) : this(dni, email)
        {
            this.MateriaAsignada = materiaAsignada;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Email: {this.email}");
            sb.AppendLine($"Materia: {this.MateriaAsignada}");
            return sb.ToString();
        }

        public bool Evaluar(Alumno alumno)
        {
            return alumno.RendirExamen(this.MateriaAsignada);
        }

        public override string ToString()
        {
            return $"Profesor - {this.MateriaAsignada}";
        }
    }
}
