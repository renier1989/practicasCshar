using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCharacters.Interfaces
{
    internal interface IPersonaje
    { 
        int Id { get; set; }
        string Nombre { get; set; }
        string Tipo { get; set; }
    }
}
