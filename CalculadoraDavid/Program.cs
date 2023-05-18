using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Calculadora básica");
        Console.WriteLine("------------------");

        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Elija una operación:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        Console.Write("Ingrese el número de la operación deseada: ");
        int operacion = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;

        switch (operacion)
        {
            case 1:
                resultado = numero1 + numero2;
                break;
            case 2:
                resultado = numero1 - numero2;
                break;
            case 3:
                resultado = numero1 * numero2;
                break;
            case 4:
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }