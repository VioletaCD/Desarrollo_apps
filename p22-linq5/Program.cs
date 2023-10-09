// Consultas LINQ5

List<Estudiante> estudiantes = new List<Estudiante>();
estudiantes.Add(new Estudiante("1234", "Juan Perez   ", "La Pasadita 201   ", "Zacatecas",  'H', 21, true,  new List<float>{97,92,81,68}));
estudiantes.Add(new Estudiante("2345", "Maria Lopez  ", "Principal 126     ", "Fresnillo",  'M', 21, false, new List<float>{75,84,91,40}));
estudiantes.Add(new Estudiante("3456", "Rodrigo Mata ", "Av. Mexico 114    ", "Rio Grande", 'H', 31, true,  new List<float>{66,44,22,55}));
estudiantes.Add(new Estudiante("4567", "Miguel Mejia ", "La Loma 666       ", "Fresnillo",  'H', 31, true,  new List<float>{90,42,71,65}));
estudiantes.Add(new Estudiante("5678", "David Monreal", "5 de Mayo 23      ", "Rio Grande", 'H', 41, false, new List<float>{90,80,60,60}));
estudiantes.Add(new Estudiante("6789", "Breanda Giron", "Av. Rayon 12      ", "Zacatecas",  'M', 22, true,  new List<float>{37,52,71,65}));
estudiantes.Add(new Estudiante("7890", "Lili Morones ", "Sierra Madre    23", "Rio Grande", 'M', 45, false, new List<float>{99,88,77,66}));
estudiantes.Add(new Estudiante("8901", "Juan Perez   ", "Sierra Mezquite 34", "Fresnillo",  'H', 25, true,  new List<float>{34,22,33,22}));
estudiantes.Add(new Estudiante("9012", "Rocio Bernal ", "Calle Amargura 66 ", "Fresnillo",  'M', 25, true,  new List<float>{77,66,33,22}));

Console.WriteLine("\nTodos los Estudiantes en el Grupo:");
estudiantes.ForEach(e=>Console.WriteLine(e));

string mun = "Zacatecas";
//var estmun = (from e in estudiantes where e.Municipio==mun select e).ToList();
var estmun = estudiantes.Where(e=>e.Municipio==mun).ToList();
Console.WriteLine($"\nEstudiantes que son de {mun} - {estmun.Count()}");
estmun.ForEach(e=>Console.WriteLine(e));

float prom = 88f;
//var estprom = (from e in estudiantes where e.Califs.Average() >= prom orderby e.Nombre select e).ToList();
var estprom = estudiantes.Where(e=>e.Califs.Average()>=prom).ToList();
Console.WriteLine($"\nEstudiantes con promedio: >={prom} - {estprom.Count()}");
estprom.ForEach(e=>Console.WriteLine(e));

//var estprom1 = (from e in estudiantes select $"Nombre = {e.Nombre,-18} - Prom = {e.Califs.Average(),5:n2} Becado = {e.Becado}").ToList();
var estprom1 = estudiantes.Select(e=> new {Nombre=e.Nombre, Promedio=e.Califs.Average()}).ToList();
Console.WriteLine("\nLista de alumnos y promedios: ");
estprom1.ForEach(e=>Console.WriteLine(e));

Console.WriteLine("\nSubtotales: ");
//var pedades = (from e in estudiantes select e.Edad).Average();
var pedades = estudiantes.Average(e=>e.Edad);
Console.WriteLine($"Promedio de edades = {pedades:n2}");
//var pcalifs = (from en in estudiantes select en.Califs.Average()).Average();
var pcalifs = estudiantes.Average(e=>e.Califs.Average());
Console.WriteLine($"Promedio de Promedios = {pcalifs:n2}");

//var totm = (from e in estudiantes where e.Sexo=='M' select e).Count();
var totm = estudiantes.Count(e=>e.Sexo=='M');
Console.WriteLine($"Total de Mujeres = {totm}");
//var toth = (from e in estudiantes where e.Sexo=='H' select e).Count();
var toth = estudiantes.Count(e=>e.Sexo=='H');
Console.WriteLine($"Total de Hombres = {toth}");

//var totb = (from e in estudiantes where e.Becado select e).Count();
var totb = estudiantes.Count(e=>e.Becado);
Console.WriteLine($"Total de Becados = {totb}");
//var totnb = (from e in estudiantes where !e.Becado select e).Count();
var totnb = estudiantes.Count(e=>!e.Becado);
Console.WriteLine($"Total de No Beados = {totnb}");

//var totmb = (from e in estudiantes where e.Becado && e.Sexo=='M' select e).Count();
var totmb = estudiantes.Count(e=>e.Becado && e.Sexo=='M');
Console.WriteLine($"Total de Mujeres Becadas = {totmb}");

//var gpoest = from e in estudiantes group e by e.Municipio;
var gpoest = estudiantes.GroupBy(e=>e.Municipio);
Console.WriteLine("\nEstudiantes agrupados por municipio: ");
foreach (var gpo in gpoest)
{
    Console.WriteLine($"\n {gpo.Key} : {gpo.Count()}");
    foreach(var est in gpo){
        Console.WriteLine(est);
    }
}