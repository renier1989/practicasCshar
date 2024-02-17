using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCharacters.Models
{
    class Personaje
    {
        public int Id;

        //aqui estoy usando el concepto de encapsulamiento
        private string _Nombre;
        // este encapsulamiento es de lectura (get) y escritura(set)
        public string Nombre { 
            // esto obtiene el valor que se le es asignado
            get {
                return _Nombre;
            }
            // esto modifica el valor , lo que se quiere es que cuando se le pasa un valor mal escrito con espacios estos se limpien
            set { 
                _Nombre = value.Trim();
            }
        }
        // esto es un encapsulamiento de solo lectura
        public string NombreYTipo {  get { return $"{_Nombre} es un {Tipo} "; } }
        
        public string Tipo;
        //public string[] Habilidades;
        public List<Habilidad> Habilidades; // esto es para definir una lista de habilidades
        public bool UseTheForce;

        //aqui definimos el constructor de la clase
        // esto es util para poder inicializar los valores
        public Personaje() // CONSTRUCTOR
        {
            Id = 1;
            Habilidades = new List<Habilidad>(); // quiere decir que puede ser un lista vacia
            UseTheForce = false;
        }

        //// una funcion que no retorna nada void
        //public void UsarHabilidades()
        //{
        //    foreach (var skill in Habilidades)
        //    {
        //        Console.WriteLine($"{Nombre} estas usando la/s habilidade/s {skill.Nombre}");
        //    }
        //}

        ////una funcion que retorna la concatenacion de un string que son lo poderes
        public string UsarHabilidades()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var skill in Habilidades)
            {
                sb.AppendLine($"{NombreYTipo} estas usando la/s habilidade/s {skill.Nombre}");
            }
            return sb.ToString();
        }
    }

}
