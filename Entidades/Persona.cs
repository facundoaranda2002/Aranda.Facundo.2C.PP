using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        protected int dni;
        private string nombre;

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public abstract string Informacion { get; }

        protected Persona(int dni)
        {
            this.dni = dni;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Nombre: {this.Nombre}");
            return sb.ToString();
        }

        public static bool operator ==(Persona personaA, Persona personaB)
        {
            return personaA.dni == personaB.dni;
        }

        public static bool operator !=(Persona personaA, Persona personaB)
        {
            return !(personaA == personaB);
        }

        public override bool Equals(object? obj)
        {
            Persona persona = obj as Persona;
            return persona is not null && this == persona;
        }

        public override int GetHashCode()
        {
            return this.dni.GetHashCode();
        }
    }
}