using StarWarsCharacters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCharacters
{
    internal class ImprimirDatos
    {
        public void ImprimirDatosPersonaje(IPersonaje datosPersonaje)
        {
            Console.WriteLine($"ID : {datosPersonaje.Id}");
            Console.WriteLine($"NOMBRE : {datosPersonaje.Nombre}");
            Console.WriteLine($"TIPO : {datosPersonaje.Tipo}");
        }
    }
}
