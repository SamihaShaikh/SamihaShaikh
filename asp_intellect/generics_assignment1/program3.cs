using System;
using System.Collections.Generic;
using System.Text;

namespace generics_assignment1
{
   class program3
    {
      public static void Main(string[] args)
        {
            int m, n, i, j;
            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The First Matrix : \n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            int[,] B = new int[10, 10];
            Console.Write("\nEnter The Second Matrix : \n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.Clear();
            Console.WriteLine("\nMatrix A : \n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix B: \n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + "\t");

                }
                Console.WriteLine();
            }

            //addition
            int[,] C = new int[10, 10];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            Console.Write("\nAddition of 2 Matrices : \n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(C[i, j] + "\t");

                }
                Console.WriteLine();
            }

            //subtraction
            int[,] d = new int[10, 10];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    d[i, j] = A[i, j] - B[i, j];
                }
            }
            Console.Write("\nSubtraction of 2 Matrices : \n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(d[i, j] + "\t");

                }
                Console.WriteLine();
            }

            //multiplication

            int[,] e = new int[10, 10];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    e[i, j] = A[i, j] * B[i, j];
                }
            }
            Console.Write("\n Multiplication of 2 Matrices : \n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(e[i, j] + "\t");

                }
                Console.WriteLine();
            }

            //division

            int[,] f = new int[10, 10];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    f[i, j] = A[i, j] / B[i, j];
                }
            }
            Console.Write("\n Division of 2 Matrices : \n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(f[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
