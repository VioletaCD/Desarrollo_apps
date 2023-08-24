//programa  calificaciones

int n=0, ne=0;
float cal=0, suma=0, promedio=0, promgral=0;
string status="";
char resp;

do{
    Console.Clear();
    promedio=suma=n=0;
    Console.WriteLine("Procesa n calificaciones, del semestre agosto diciembre 2023\n");

    do{
        Console.Write("Calificación: "); cal = int.Parse(Console.ReadLine());
        if(cal!=666){
            suma+=cal;
            n++;
        }
        
    }while(cal!=666);

    promedio = suma/n;
    status = promedio>=6 ? "APROBADO" : "REPROBADO";
    Console.WriteLine($"Capturaste {n} calificaciones");
    Console.WriteLine($"La suma de las calificaciones es: {suma:f2}");
    Console.WriteLine($"El promedio es: {promedio:f2} ");
    Console.WriteLine($"Tu estatus es de: {status}");
    ne++;
    promgral+=promedio;
    Console.WriteLine("\nDeseas capturar más calificaciones (S/N): ");
    resp = char.ToUpper(Console.ReadLine()[0]);
}while(resp!='N');
promgral/=ne;
Console.WriteLine($"Se procesaron las calificaciones de {ne} estudiantes");
Console.WriteLine($"Promedio general de la  clase {promgral}");