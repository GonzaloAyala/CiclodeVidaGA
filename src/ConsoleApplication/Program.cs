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
            //List<Train> trenes = new List<Train>();
            for (int i = 0; i<30000; i++)
            {
                string name = "Tren" + i.ToString();
                //trenes = trenes(new Train(name));
                new Train(name);
                Console.WriteLine(Train.getNumeroTrenesPrint());
            }
            Train t1 = new Train("Last train to London");
            Train t2 = new Train("Last train to London");
            Train t3 = new Train("Runaway Train");
            Console.WriteLine($"t1 == t2: {t1 == t2} t2 == t3 {t2 == t3}");
            //Ambas dan falso ya que son tres objetos diferentes, a pesar de que t1 y t2 tengan el mismo estado.
        }
    }
}