List<string> frutas = new() {"pera","melon","sandia","durazno","manzana","platano","kiwi","naranja","jicama","piña"};
Console.Clear();
// Consultas usando métodos de cadena, con sinstaxis integrada
var mfrutas = (from f in frutas where f.StartsWith('m') select f).ToList();
Console.Write("\nFrutas que inician con la letra m - {0} : ",mfrutas.Count() );
mfrutas.ForEach(f=>Console.Write(f+" "));
var anfrutas = (from f in frutas where f.Contains("an") select f).ToList();
Console.Write("\nFrutas que contienen las letras an - {0} : ", anfrutas.Count());
anfrutas.ForEach(f=>Console.Write(f+" "));
var frutasa = (from f in frutas where f.EndsWith('a') select f).ToList();
Console.Write("\nFrutas que terminan con la letra a - {0} : ", frutasa.Count());
frutasa.ForEach(f=>Console.Write(f+" "));
Console.WriteLine();
// Consultas usando métodos de cadena, con métodos de extensión
var mfrutas1 = frutas.Where(f=>f.StartsWith('m')).ToList();
Console.Write("\nFrutas que inician con la letra m - {0} : ",mfrutas1.Count() );
mfrutas1.ForEach(f=>Console.Write(f+" "));
var anfrutas1 = frutas.Where(f=>f.Contains("an")).ToList();
Console.Write("\nFrutas que contienen las letras an - {0} : ", anfrutas1.Count());
anfrutas1.ForEach(f=>Console.Write(f+" "));
var frutasa1 = frutas.Where(f=>f.EndsWith('a')).ToList();
Console.Write("\nFrutas que terminan con la letra a - {0} : ", frutasa1.Count());
frutasa1.ForEach(f=>Console.Write(f+" "));
