List<double> califs = new() {9.5,8.5,10.0,7.4,6.5,8.2,9.7,5.0,2,0,3.5};
Console.Clear();
Console.Write("Las calificaciones: ");
califs.ForEach(cal=>Console.Write(cal+" "));
Console.WriteLine("\n");
// Consulta para generar reprobados, usando sintaxis integrada
var rep = from cal in califs where cal<=6 select cal;
Console.WriteLine("Reprobados : " + rep.Count());
// Consulta para generar aprobados, usando métodos de extensión
var apr = califs.Where(cal=>cal>=7);
Console.WriteLine("Aprobados : " + apr.Count());
// Suma, promedio, máximo, mínimo, solo se puede con métodos de extensión
Console.WriteLine("La suma es " + califs.Sum() + ", El promedio es " + califs.Average());
Console.WriteLine("Mas alta " + califs.Max() + ", Mas baja " + califs.Min());
// Consulta para obtener los menores al promedio, usando sintaxis integrada
var menp = ( from cal in califs where cal < califs.Average() select cal ).ToList();
Console.WriteLine("\nMenores al promedio: " + menp.Count() );
menp.ForEach(cal=>Console.Write(cal+" "));
// Consulta para obtener los mayores al promedio, usando métodos de extensión
var mayp = califs.Where(cal=> cal > califs.Average() ).ToList();
Console.WriteLine("\nMayores al promedio: " + mayp.Count() );
mayp.ForEach(cal=>Console.Write(cal+" "));
// Ordenar ascendente y descendente, usando sintaxis integrada
Console.WriteLine("\n\nLista ordenada ascendente:");
var ord1 = (from cal in califs orderby cal select cal).ToList();
ord1.ForEach(cal=>Console.Write(cal+" "));
Console.WriteLine("\nLista ordenada descendente:");
var ord2 = (from cal in califs orderby cal descending select cal).ToList();
ord2.ForEach(cal=>Console.Write(cal+" "));
// Ordenar ascendente y descendente, usando métodos de extensión
Console.WriteLine("\n\nLista ordenada ascendente:");
var ord3 = califs.OrderBy(c=>c).ToList();
ord3.ForEach(cal=>Console.Write(cal+" "));
Console.WriteLine("\nLista ordenada descendente:");
var ord4 = califs.OrderByDescending(c=>c).ToList();
ord4.ForEach(cal=>Console.Write(cal+" "));
