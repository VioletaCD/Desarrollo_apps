char tam, cub, don;
string[] ings;
string tamaño="", ingredientes="", cubierta, donde;
int cant=0;
float total=0;
if(args.Length==0) {
Menu();
return 1;
}
// Elegir tamaño
tam=char.Parse(args[0].ToUpper());
if(tam=='P') { tamaño="Pequeña"; total+=10; }
else if(tam=='M') { tamaño="Mediana"; total+=20; }
else { tamaño="Grande"; total+=30; }
// Elegir ingredientes
ings=args[1].Split("+");
foreach(string i in ings) {
total+=5;
switch(char.Parse(i.ToUpper())) {
case 'E' : ingredientes+="Extraqueso ";break;
case 'C' : ingredientes+="Champiñones ";break;
case 'P' : ingredientes+="Piña ";break;
}
}
// Tipo de Cubierta
cub=char.Parse(args[2].ToUpper());
cubierta= (cub=='D' ? "Delgada": "Gruesa");
// Donde la consume
don=char.Parse(args[3].ToUpper());

donde= (don=='A' ? "Aqui": "Llevar");
// Cantidad de pizzas
cant=int.Parse(args[4]);
total*=cant;
// Resultado del pedido
Console.WriteLine("Tu pizza queda asi:\n");
Console.WriteLine("Tamaño : {0} ",tamaño);
Console.WriteLine("Ingredientes: {0} ",ingredientes);
Console.WriteLine("Cubierta : {0} ",cubierta);
Console.WriteLine("Consumes : {0} ",donde);
Console.WriteLine("Total : {0:c2} ",total);
return 0;
static void Menu() {
Console.Clear();
Console.WriteLine("\nElije como deseas armar tu pedido de pizza\n");
Console.WriteLine("Tamaño : [P]equeña-$10 [M]ediana-$20 [G]rande-$30");
Console.WriteLine("Ingredientes : [E]xtra queso [C]hampiñoness [P]iña , unidos por un + ($5)");
Console.WriteLine("Cubierta : [D]elgada [G]ruesa");
Console.WriteLine("Donde : [A]qui [L]levar");
Console.WriteLine("Cantidad : ");
}