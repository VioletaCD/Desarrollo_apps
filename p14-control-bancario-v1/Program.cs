﻿//PROGRAMA PRINCIPAL

Console.Clear();

Console.WriteLine("\n Probando Cuenta Bancaria");
CuentaBancaria cuenta1= new CuentaBancaria(5000);
cuenta1.Deposita(10000);
Console.WriteLine($"El saldo es: {cuenta1.Saldo}");
bool retiro = cuenta1.Retira(56);
if(retiro) Console.WriteLine($"Retiro efectuado, nuevo saldo: {cuenta1.Saldo}");
else Console.WriteLine("SALDO INSUFICIENTE");

Console.WriteLine("\n Probando Clase Cliente");
Cliente cliente1 = new Cliente("Bruno","Díaz");
cliente1.Cuenta = cuenta1;
Console.WriteLine($"Cliente: {cliente1.ToString()}");
Console.WriteLine($"El saldo es: {cliente1.Cuenta.Saldo}");

Cliente cliente2 = new Cliente("Daira","Calani");
cliente2.Cuenta =new CuentaBancaria(100000000);
cliente2.Cuenta.Retira(50000);
Console.WriteLine($"Cliente: {cliente2.ToString()}");
Console.WriteLine($"El saldo es: {cliente2.Cuenta.Saldo}");

Console.WriteLine("\n Probando CLASE BANCO");
Banco mibanco =new Banco ("Banco Patito SA de CV","Arboledas 124");
mibanco.AgregarCliente(cliente1);
mibanco.AgregarCliente(cliente2);

Cliente cliente3 =new Cliente("Omar Asahel","Obviedo");
cliente3.Cuenta =new CuentaBancaria(10001);
mibanco.AgregarCliente(cliente3);
mibanco.Clientes[0].Cuenta.Deposita(10000);
mibanco.Clientes[1].Cuenta.Retira(1000);
mibanco.Clientes[2].Cuenta.Deposita(35000);
Console.WriteLine("\n Resumen del Banco\n");
Console.WriteLine($"Banco: {mibanco.ToString()}");
foreach(Cliente cl in mibanco.Clientes){
    Console.WriteLine($"Cliente: {cl.ToString()}");
    Console.WriteLine($"Saldo: {cl.Cuenta.Saldo}");
}
