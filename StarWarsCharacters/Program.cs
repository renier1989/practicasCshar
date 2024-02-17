﻿using StarWarsCharacters.Models;

//// aqui defino los tipos de habilidades y mas detalles

using System.Text;

var habilidadEmpuje= new Habilidad();
habilidadEmpuje.Nombre = "Lanzamiento de la fuerza";
habilidadEmpuje.Descipcion = "La habilidad de realizar un empuje usando la fuerza";
habilidadEmpuje.Rango = RangoHabilidad.Padawan;


var habilidadControlMental = new Habilidad();
habilidadControlMental.Nombre = "Control Mental";
habilidadControlMental.Descipcion = "La habilidad de influir en las mentes debiles";
habilidadControlMental.Rango = RangoHabilidad.MaestroJedi;

var habilidadRayos = new Habilidad();
habilidadRayos.Nombre = "Rayos de la fuerza";
habilidadRayos.Descipcion = "La Habilidad de crear rayos de fuerza desde las manos";
habilidadRayos.Rango = RangoHabilidad.LordSith;


////aqui definimos el objeto en base a la clase de Personaje

/// Objeto Yoda
var yoda = new Personaje();

yoda.Id = 1;
yoda.Nombre = "     Yoda      ";
yoda.Tipo = "Jedi";
yoda.UseTheForce = true;
// se debe crear una lista que sera asignada a personaje de yoda
List<Habilidad> habilidadesYoda = new List<Habilidad>();
habilidadesYoda.Add(habilidadControlMental);
habilidadesYoda.Add(habilidadEmpuje);
yoda.Habilidades = habilidadesYoda;
//// aqui hago uso del meto de UsarHabilidad
//yoda.UsarHabilidades();
string yodausandohabilidades = yoda.UsarHabilidades();
Console.WriteLine(yodausandohabilidades);


///// Objeto Yoda
//var yoda2 = new Personaje();

//yoda2.Id = 1;
//yoda2.Nombre = "Yoda";
//yoda2.Tipo = "Jedi";
//yoda2.UseTheForce = true;
//// se debe crear una lista que sera asignada a personaje de yoda
//List<Habilidad> habilidadesYoda2 = new List<Habilidad>();
//habilidadesYoda2.Add(habilidadControlMental);
//habilidadesYoda2.Add(habilidadEmpuje);
//yoda2.Habilidades = habilidadesYoda2;


////hago una comparacion de los dos objetos de yoda
//Console.WriteLine(yoda == yoda2); // esto devuelve el valor de FALSE aunque tengan los mismo valores en los objetos no se puedes comparar los valores internos

//PersonajeRecord PJR1 = new(1,"pj1","jedi");
//PersonajeRecord PJR2 = new(1, "pj1", "jedi");

//Console.WriteLine(PJR1 == PJR2); // esto si devuelve el valor de TRUE porque la creacion de un record si hace la comparacion de los valores en el objeto





/// Objeto Maul
var maul = new Personaje();

maul.Id = 2;
maul.Nombre = "Dath Maul";
maul.Tipo = "Sith";
maul.UseTheForce = true;

List<Habilidad> habilidadesMaul = new List<Habilidad>();
habilidadesMaul.Add(habilidadRayos);

maul.Habilidades = habilidadesMaul;






enum RangoHabilidad
{
    Padawan,
    CaballeroJedi,
    MaestroJedi,
    Sith,
    LordSith,
    MaestroSith,
}

//definicion de un record para realizar la comparacion
public  record PersonajeRecord(int Id, string Nombre ,string Tipo);