public class Cliente {
public String Nombre {get; set;}
public String Apeido {get; set;}
public CuentaBancaria Cuenta {get; set;}
public Cliente(string nombre, string apeido) => (Nombre,Apeido) = (nombre, apeido);
public override string ToString() => $"{Nombre}, {Apeido}";
}