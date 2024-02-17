using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCharacters.Models
{
    // esto es para poder darle una forma a las habilidades
    class Habilidad
    {
        public string Nombre;
        public string Descipcion = " Valor por defecto"; // tambien se pueden definir valores por defecto desde aqui sin el constructor pero no es un buena practica.
        public RangoHabilidad Rango; // aqui se le debe espedificar el tipo de RangoHabilidad

        public Habilidad()// CONSTRUCTOR
        {
            Rango = RangoHabilidad.Padawan;
        }
    }

}
