using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCharacters.Models
{
    internal class HeroeVillano:Personaje
    {
        // esto es un metodo que solo tiene esta clase. no puede ser usado por la clase padre de Personaje
            
        public string AccionDelHeroeVillano( string accion) 
        {
            return $"{Nombre}, se catacteriza por: {accion}";
        }

    }
}
