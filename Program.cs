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
}