using System;
 
class Reporte
{
    // REFERENCIA promedio, máximo y mínimo
    static void Estadisticas(int[] notas, ref double promedio, ref int maximo, ref int minimo)
    {
        int suma = 0;
        maximo = notas[0];
        minimo = notas[0];
 
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
 
            if (notas[i] > maximo)
                maximo = notas[i];
 
            if (notas[i] < minimo)
                minimo = notas[i];
        }
 
        promedio = (double)suma / notas.Length;
    }
     //valor : aprobados

    static int AprobadoNumeros (int[] notas)
    {
        int aprobados = 0;
 
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= 12)
                aprobados++;
        }
 
        return aprobados;
    }
    //Programa principal
    static void Main()
    {
        // 1.cantidad de notas
        int cantidad = 0;
        Console.Write("¿Cuántas notas deseas ingresar? ");
 
        while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
        {
            Console.WriteLine("Error. el numero tiene que ser un numero entero.");
            Console.Write("¿Cuantas notas deseas ingresar? ");
        }
 
        int[] notas = new int[cantidad];
 
        Console.WriteLine();
 
        // 2. Ingresar notas con validación
        for (int i = 0; i < cantidad; i++)
        {
            int nota;
            bool valida = false;
 
            do
            {
                Console.Write($"Ingresa la nota {i + 1}: ");
                bool esNumero = int.TryParse(Console.ReadLine(), out nota);
 
                if (!esNumero || nota < 0 || nota > 20)
                {
                    Console.WriteLine("Nota invalida, ingresa entre 0 y 20.");
                    valida = false;
                }
                else
                {
                    valida = true;
                }
            } while (!valida);
 
            notas[i] = nota;
            Console.WriteLine();
        }
 
        //3. Calcular estadísticas (por referencia)
        double promedio = 0;
        int maximo = 0, minimo = 0;
 
        Estadisticas(notas, ref promedio, ref maximo, ref minimo);
 
        //4. Contar aprobados (por valor)
        int aprobados    = AprobadoNumeros(notas);
        int desaprobados = cantidad - aprobados;
 
        double pctAprobados    = (double)aprobados    / cantidad * 100;
        double pctDesaprobados = (double)desaprobados / cantidad * 100;
 
        //5. Imprimir reporte
        Console.WriteLine("--- Reporte del Salón ---");

        Console.Write("Notas Ingresadass: [");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write(notas[i]);
            if (i < notas.Length -1)
            Console.Write(", ");
        }
        Console.WriteLine("]");

    }














}