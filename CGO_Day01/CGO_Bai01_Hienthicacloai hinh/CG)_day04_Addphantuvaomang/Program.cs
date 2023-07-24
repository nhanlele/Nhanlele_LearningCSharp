﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG__day04_Addphantuvaomang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap Phan Tu Thu {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Nhap Gia Tri Can them (X): ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Nhap Vi tri index can them (tu 0 den 9): ");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Khong them duoc phan tu vao mang vui long chon so hop le tu 0 den 9.");
            }
            else
            {

                for (int i = array.Length - 1; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = X;

                Console.WriteLine("mang sau khi them:");
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
            }
        }
    }
}