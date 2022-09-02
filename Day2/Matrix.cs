using System;
using System.Drawing;

namespace Day2
{
    internal class Matrix
    {
        public static void InitMatrix()
        {
            int[,] matrix = new int[5, 5];
            matrix[2, 2] = 125;
        }
        public static int[,] FillRandomMatrix(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(0, 20);
                }
            }
            return matrix;
        }


        public static int MunculBerapa(int[] arr)
        {
            int[] aku = new int[arr.Length];
            int count = 0;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (arr[i] == arr[i] || arr[i] == 0)
                {
                    aku[i] = arr[i];
                }
                Console.WriteLine($"{aku[i]} muncul {count} kali");
            }
            return count;
        }

 
        public static int[,] MatrixDiagonal(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // diagonal itu baris dan kolom sama
                    if (i == j)
                    {
                        matrix[i, j] = counter++;
                    } else if (j > i)
                    {
                        matrix[i, j] = 10;
                    } else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            return matrix;
        }


        public static int[,] MatrixDiagonal2(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = 5;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // diagonal itu baris dan kolom sama
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }
                }
            }
            return matrix;
        }
        

        public static int[,] MatrixDiagonalRandom(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int jumlah = 0;
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // diagonal itu baris dan kolom sama
                    if (i == j)
                    {
                        matrix[i, j] = r.Next(0,100);
                        jumlah += matrix[i,j];
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }
                }
            }
            Console.WriteLine($"Jumlah Nilai Random : {jumlah}");
            return matrix;
        }

        public static int Student(char[,] scores, char[] keys)
        {
            char[,] nilai = scores;
            char[] kunci = keys;
            int count = 0;
            for (int i = 0; i < nilai.GetLength(0); i++)
            {
                count = 0;
                Console.Write($"Jawa Siswa {i} :");
                for (int j = 0; j < nilai.GetLength(1); j++)
                {
                    Console.Write($"{nilai[i, j]} ");

                    if (nilai[i, j] == kunci[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"\nJawaban Siswa {i} yang benar : {count}\n");
            }
            return count;

        }

        public static int[,] MatrixBox(int row, int col)
        {
            int[,] matrix = new int[row, col];
            /*int counterrow = 0;
            int countercol = 1;*/
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i+j;
                    if (i != 0 && j != 0)
                    {
                        if(i != row - 1 && j != col-1)
                        {
                            matrix[i, j] = 0;
                        }
                    }

                }
            }
            return matrix;
        }

        public static int[,] MatrixBox2(int row, int col)
        {
            int[,] matrix = new int[row, col];
            int jumlah = 0;
            int jumlah0 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i != row -1 && j!= row - 1)
                    {
                        matrix[i, j] = i + j;
                        if ( j <= row - 1)
                        {
                            jumlah += matrix[i, j];
                            matrix[i, row - 1] = jumlah;
                            matrix[row - 1, i] = jumlah;
                        }
                        if (i == j)
                        {
                            jumlah0 += matrix[i, j];
                            matrix[row - 1, row - 1] = jumlah0;

                        }
                        if( j == row - 2)
                        {
                            jumlah = 0;
                        }

                    }
                }
            }
            return matrix;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) //baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //colom
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}



// diagonal itu baris dan kolom sama
/*  if (i == 0)
  {
      matrix[i, j] = counterrow++;
  }
  else if (j == 0 )
  {
      matrix[i, j] = countercol++;
  }
  else if (i == row-1)
  {
      matrix[i, j] = countercol++;
  }
  else if (j == col - 1 )
  {
      matrix[i, j] = counterrow++;
  }
  else
  {
      matrix[i, j] = 0;
  }*/