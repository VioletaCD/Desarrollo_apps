// Imprime tabla de conversión de peso a dolar
int ini, fin, c;
float tcd = 17.70f, tcl=21.21f, tce=18.19f, tca=0.048f;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime una tabla de conversion de monedas\n");
    do {
        Console.Write("Inicio : "); ini = int.Parse(Console.ReadLine());
        Console.Write("Fin : "); fin = int.Parse(Console.ReadLine());
    } while(fin<ini); //valida que ini sea menor que fin
    
    c=ini;
    Console.WriteLine(new string('-',45));
    Console.WriteLine("Peso\tDolar\tLibra\tEuro\tPeso A");
    Console.WriteLine(new string('-',45));
    while( c<=fin ) {
    Console.WriteLine($"{c}\t{c/tcd:f2}\t{c/tcl:f2}\t{c/tce:f2}\t{c/tca:f2}");
    c++;
}
Console.WriteLine(new string('-',45));
Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nGracias por utilizar este programa !");    
