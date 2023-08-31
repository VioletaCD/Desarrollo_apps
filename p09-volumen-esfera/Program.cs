 //Programa que calcula el volumen de una esfera

 Console.Clear();
 Console.WriteLine("Programa que calcula el volumen de una esfera\n");
 Console.Write("Ingrese el radio de la esfera: ");
    double radio = Convert.ToDouble(Console.ReadLine());

    double volumen = CalcularVolumenEsfera(radio);
    Console.WriteLine($"El volumen de la esfera con radio {radio} es: {volumen:f2}");

        Console.ReadLine();
        

    static double CalcularVolumenEsfera(double radio)
    {
        double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
        return volumen;
    }
    


