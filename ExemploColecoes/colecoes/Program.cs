﻿using System;

namespace colecoes
{
    class Program
    {
        static void Main(string[] args)
        { //ARRAY MULTIDIMENSIONAL  
            int[,] matriz = new int[4,2]
            {
                {8,8},
                {10,20},
                {50,100},
                {50,100}
            };
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.WriteLine(matriz[i,j]);
                }
            }

            //PERCORRENDO ARRAY EM C#
    //        int []arrayInteiros = new int[3];
    //        arrayInteiros [0] = 10;
    //        arrayInteiros [1] = 20;
    //        arrayInteiros [2] = 30;
    //        System.Console.WriteLine("Percorrendo o array pelo for:");
    //        for (int i = 0; i < arrayInteiros.Length; i++)
    //        {
    //            System.Console.WriteLine(arrayInteiros[i]);
    //        }
    //        System.Console.WriteLine("Percorrendo o array pelo foreach:");
    //        foreach (int item in arrayInteiros)
    //        {
    //            System.Console.WriteLine(item);
    //        }
        }
     }
}
