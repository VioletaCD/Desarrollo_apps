// Consultas LINQ
// Origen de datos
List<int> numeros = new() {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
// Crear consulta, sintaxis integrada
Console.WriteLine("\nNumeros pares:");
var pares = from num in numeros where num%2==0 select num;
foreach(int num in pares)
Console.WriteLine(num);
// Crear consulta, métodos de extensión
Console.WriteLine("\nNumeros impares:");
var impares = numeros.Where(num => num%2!=0);
foreach(int num in impares)
Console.WriteLine(num);

// Crear Consulta sintaxis integrada y convertir a List<>
Console.WriteLine("\nNúmeros entre 5 y 9");
var rango1 = (from num in numeros where num>=5 && num<=9 select num).ToList();
rango1.ForEach(n=>Console.WriteLine(n)); // Método ForEach de la lista para imprimir
// Crear consulta, métodos de extensión y convertir a List<>
Console.WriteLine("\nNúmeros entre 1 y 4");
var rango2 = numeros.Where(num=> num>=1 && num<=4).ToList();
rango2.ForEach(n=>Console.WriteLine(n)); // Método ForEach de la lista para imprimir
