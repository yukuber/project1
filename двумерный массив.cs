using System;

class two_dim
{
    private int[,] array2;
    private static Random rand = new Random();
    
    public two_dim(int high_d2, int len_d2, bool fill_rand)
    {
        ReCreate(high_d2, len_d2, fill_rand);
    }

    private void d2_rand()
    {
        Random rnd = new Random();
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array2[i, j] = rnd.Next(-100, 100);
            }
        }
    }
    
    private void d2_manual()
    {
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                array2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public static void average_d2()
    {
        int sam = 0;
        foreach (int elem in array2)
        {
            sam += elem;
        }
        Console.WriteLine($"средн арифм в двумерном массиве " + sam/array2.Length);
    }

    public void obr_chet()
    {
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            if ((i + 1) % 2 == 0)
            {
                for (int j = array2.GetLength(1) - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        Console.WriteLine($"{array2[i, j]}");
                    }
                    else
                    {
                        Console.Write($"{array2[i, j]}");
                    }
                }
            }
            else
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    if (j == -1)
                    {
                        Console.WriteLine($"{array2[i, j]}");
                    }
                    else
                    {
                        Console.Write($"{array2[i, j]}");
                    }
                }
            }
        }
    }
    
    public void ReCreate(int high_d2, int len_d2, bool fill_rand)
    {
        array2 = new int[high_d2, len_d2];

        if (fill_rand)
        {
            d2_rand();
        }
        else
        {
            d2_manual();
        }
    }
}
