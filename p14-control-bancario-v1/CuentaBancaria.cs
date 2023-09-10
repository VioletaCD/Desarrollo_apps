public class CuentaBancaria{
    public double Saldo{get; private set;}

    public CuentaBancaria(double cantidad)=> Saldo = cantidad;

    public void Deposita(double cantidad) => Saldo += cantidad;

    public bool Retira(double cantidad) {
        if(Saldo>=cantidad){
            Saldo-= cantidad;
            return true;
        }else return false;
    }
}