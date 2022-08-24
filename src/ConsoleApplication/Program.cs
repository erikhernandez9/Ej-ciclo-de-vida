//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train("Tren"); // Lo cree aca primero por el metodo StartEgines()
            train.StartEngines();
            Console.WriteLine(train.Count);

            for(int i = 1; i < 100; i++)
            {
                train = new Train("Tren");
            }
            /*for(int i = 1; i < 1000000; i++) // Luego de cierto numero, se comienzan a liberar espacios de memoria ocupados por objetos, para almacenar los nuevos objetos
            {
                train = new Train("Tren");
            }*/
            Console.WriteLine(train.Count);

            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");

            Console.WriteLine($"t1 == t2 = {t1 == t2}; t2 == t3 = {t2 == t3};"); // Retorna false en las dos porque cada variable hace referencia a un objeto diferente

        }
    }
}