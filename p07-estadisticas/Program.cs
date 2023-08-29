const int MAX=100;
int n=0;
double[] valores = null;
double mayor=0, menor=0, promedio=0, varianza=0, desvest=0;
Console.WriteLine("Programa que genera estadisticas de numeros\n");
Console.Write("Cuantos elementos deseas calcular ? ");
n=int.Parse(Console.ReadLine());
if(n>MAX) {
Console.WriteLine("El maximo número de elementos es {0}",MAX);
}
else {
valores = new double[n];
// Leer valores del usuario
for(int i=0; i<n; i++) {
Console.Write($"valores[{i+1}] = ");
valores[i]=double.Parse(Console.ReadLine());
}
}
// Motrar los datos
Console.WriteLine($"Las calificaciones introducidas son : {est.Mostrar(valores)}");
// Calculos
mayor=est.Mayor(valores);
menor=est.Menor(valores);
promedio=est.Promedio(valores);
varianza=est.Varianza(valores,promedio);
desvest= est.Desviacion(varianza);
// Salida
Console.WriteLine("El el mayor es : {0:f2}",mayor);
Console.WriteLine("El el menor es : {0:f2}",menor);
Console.WriteLine("El Promedio es : {0:f2}",promedio);
Console.WriteLine("La varianza es : {0:f2}",varianza);
Console.WriteLine("La desviacion estandar: {0:f2}",desvest);
public static class est {
public static string Mostrar(double[] v) {
return String.Join(",",v);
}
public static double Mayor(double[] v) {
double m=v[0];
for(int i=0; i<v.Length; i++) {
if(v[i]>m) m=v[i];

}
return m;
}
public static double Menor(double[] v) {
double m=v[0];
for(int i=0; i<v.Length; i++) {
if(v[i]<m) m=v[i];

}
return m;
}
public static double Promedio(double[] v) {
double m=0;
for(int i=0; i<v.Length; i++) {

m+=v[i];

}
return m / v.Length;
}
public static double Varianza(double[] v, double p) {
double m=0;
for(int i=0; i<v.Length; i++) {
m+=Math.Pow(v[i]-p,2);

}
return m / v.Length;
}
public static double Desviacion(double var ) => Math.Sqrt(var);
}