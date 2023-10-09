List<Estudiante> estudiantes = new List<Estudiante>();
estudiantes.Add(new Estudiante("1234","Juan Perez","Principal 123","Zacatecas",'H',21,true,new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("2345","Maria Lopez","Principal 126","Fresnillo",'M',22,false,new List<float>{75,84,91,40}));
estudiantes.Add(new Estudiante("1234","Rodrigo Mata","Av Mexico 114","Rio Grande",'H',21,true,new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("2356","Miguel Mejia","La Loma 666","Fresnillo",'H',31,true,new List<float>{66,44,22,55}));
estudiantes.Add(new Estudiante("8888","David Monreal","5 de Mayo 23","Rio Grande",'H',41,false,new List<float>{98,100,85,70}));
estudiantes.Add(new Estudiante("1345","Brenda Buen Rostro","Av Rayon 45","Zacatecas",'M',22,true,new List<float>{100,65,82,65}));
estudiantes.Add(new Estudiante("2265","Liliana Morones","Sierra Madre 23","Rio Grande",'M',34,false,new List<float>{95,90,77,85}));
estudiantes.Add(new Estudiante("999","Berenice Diaz","Av Rayon","Zacatecas",'M',25,false,new List<float>{80,20,30,100}));
estudiantes.Add(new Estudiante("999","Rocio Bernal","Sirre Mezquite 143","Fresnillo",'M',25,true,new List<float>{77,66,33,22}));
Console.WriteLine("\nTodos los estudiantes tal cual estan almaencenados en la lista: ");
estudiantes.ForEach(e=>Console.WriteLine(e.ToString()));
// Diversas consultas usando la notación de sintaxis integrada
// Solo los de cierto municipio
string mun = "Rio Grande";
var estmun = (from e in estudiantes where e.Municipio == mun select e).ToList();
Console.WriteLine("\n\nEstudiantes que son de {0}: {1}", mun, estmun.Count());
estmun.ForEach(e=>Console.WriteLine(e.ToString()));
// Solo los de promedio mayor a cierto promedio
float prom = 70f;
var estprom = (from e in estudiantes where e.Califs.Average() >= prom orderby e.Nombre select e).ToList();
Console.WriteLine("\nEstudiantes con promedio >= {0} ordenados de forma descendente por Nombre: {1}", prom, estprom.Count());
estprom.ForEach(e=>Console.WriteLine(e.ToString()));
// Extraer ciertos datos de la Clase
var estprom1 = (from e in estudiantes select $"Nombre = {e.Nombre,-18} Prom = {e.Califs.Average(),5:n2}").ToList();
Console.WriteLine("\n\nLista de alumnos y sus promedios:");
estprom1.ForEach(e=>Console.WriteLine(e));

// Calcular Subtotales
Console.WriteLine("\nSubtotales:");
var pedades = (from e in estudiantes select e.Edad).Average();
Console.WriteLine($"Promedio de edades : {pedades:f2}");
var pcalifs = (from est in estudiantes select est.Califs.Average()).Average();
Console.WriteLine($"Promedio de la clase : {pcalifs:f2}");
var toth = (from e in estudiantes where e.Sexo=='H' select e).Count();
Console.WriteLine($"Total de Hombres : {toth}");
var totm = (from e in estudiantes where e.Sexo=='M' select e).Count();
Console.WriteLine($"Total de Mujeres : {totm}");
var totb = (from e in estudiantes where e.Becado select e).Count();
Console.WriteLine($"Total Becados : {totb}");
var totnb = (from e in estudiantes where !e.Becado select e).Count();
Console.WriteLine($"Total No Becados : {totnb}");
// Agrupar datos por Municipio
var gpoest = from e in estudiantes group e by e.Municipio;
Console.WriteLine("\nEstudiantes agrupados por Municipio:");
foreach(var gpo in gpoest) {
Console.WriteLine("\n" + gpo.Key + ": " + gpo.Count() );
foreach(var est in gpo)
Console.WriteLine(est.ToString());

}
