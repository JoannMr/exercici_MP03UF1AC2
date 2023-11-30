// TASCA 1

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la primera nota:");
        int nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        int nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        int nota3 = Convert.ToInt32(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3.0;  // Usamos 3.0 para evitar la división entera

        Console.WriteLine($"La nota media es: {media}");

        if (media >= 5)
        {
            Console.WriteLine("¡Enhorabuena! El alumno está aprobado.");
        }
        else
        {
            Console.WriteLine("El alumno está suspendido. ¡Ánimo para la próxima!");
        }
    }
}

// TASCA 2

class Program
{
    static void Main()
    {
        int numerosPares = 0;
        int numerosImpares = 0;

        Console.WriteLine("Ingrese números. Para finalizar, ingrese 0.");

        while (true)
        {
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
                break;

            if (numero % 2 == 0)
                numerosPares++;
            else
                numerosImpares++;
        }

        Console.WriteLine($"Cantidad de números pares: {numerosPares}");
        Console.WriteLine($"Cantidad de números impares: {numerosImpares}");
    }
}

// TASCA 3

using System;

class Program
{
    static void Main()
    {
        do
        {
            Console.Write("Introduce el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecciona la operación:");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");

            int opcion = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
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
                        resultado = numero1 / numero2;
                    else
                        Console.WriteLine("No es posible dividir por cero.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine($"El resultado es: {resultado}");

            Console.WriteLine("¿Deseas realizar otra operación?");
            Console.WriteLine("Presiona 's' para continuar o cualquier otra tecla para salir.");
        } while (Console.ReadLine().ToLower() == "s");
    }
}

// TASCA 4

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Este programa te desafía a adivinar un número de DNI cuya letra calculada siempre sea 'A'.");
        Console.WriteLine("Intenta adivinar el número de DNI.");

        while (true)
        {
            Console.Write("Introduce un número de DNI: ");
            int numeroDNI = Convert.ToInt32(Console.ReadLine());

            char letraCalculada = CalcularLetraDNI(numeroDNI);

            if (letraCalculada == 'A')
            {
                Console.WriteLine("¡Correcto! Has adivinado un número de DNI cuya letra siempre es 'A'.");
                break; 
            }
            else
            {
                Console.WriteLine("La letra calculada no es 'A'. ¡Inténtalo de nuevo!");
            }
        }
    }

    static char CalcularLetraDNI(int numeroDNI)
    {
        int indiceLetra = numeroDNI % 23;

        char[] letrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

        return letrasDNI[indiceLetra];
    }
}

// TASCA 5

using System;

class Program
{
    static void Main()
    {
        int altura = 15;

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
    }
}

// TASCA 6

using System;

class Program
{
    static void Main()
    {
        int tamaño = 8;

        for (int i = 0; i < tamaño; i++)
        {
            for (int j = 0; j < tamaño; j++)
            {
                // Alternar entre 'B' y 'N' basado en la posición
                char celda = (i + j) % 2 == 0 ? 'B' : 'N';

                Console.Write(celda);
            }
            Console.WriteLine(); // Nueva línea después de cada fila
        }
    }
}