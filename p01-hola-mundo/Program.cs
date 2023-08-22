// Programa que manda saludos a la pantalla

string amigo = "Alejandra";
string hermano = "Adan";

Console.WriteLine("Hola "+ amigo);
Console.WriteLine($"Hola {amigo} bienvenido a C#");
Console.WriteLine($"\n Mi amigo es: {amigo}, mi hermano es: {hermano}");
Console.WriteLine("Nombre en mayusculas");
Console.WriteLine($" {amigo.ToUpper()} {hermano.ToUpper()}");