using System;

{
    private int high_d2;
    private int len_d2;
    public int[,] array;
    private bool fill_rand = false;
    public two_dim(int high_d2, int len_d2)
    {
        array = new int[high_d2, len_d2];

        Console.WriteLine("Заполнять массив рандомно? да или нет");
        string ans = Console.ReadLine();
        if (ans == "да")
        {
            fill_rand = true;
        }
        if (fill_rand)
        {
            d2_rand(high_d2, len_d2);
        }
        else
        {
            d2_manual(high_d2, len_d2);
        }
    }

    private void d2_rand(int high_d2, int len_d2)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rnd.Next(-100, 100);
            }
        }
    }
    private void d2_manual(int high_d2, int len_d2)
    {

        for (int i = 0; i < high_d2; i++)
        {
            for (int j = 0; j < len_d2; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

    }

    public void average_d2()
    {
        int sam = 0;
        foreach (int elem in array)
        {
            sam += elem;
        }
        Console.WriteLine($"средн арифм в двумерном массиве " + sam);
    }

    public void obr_chet()
    {
        for (int i = 0; i < high_d2; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                for (int j = len_d2 - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        Console.WriteLine($"{array[i, j]}");
                    }
                    else
                    {
                        Console.Write($"{array[i, j]}");
                    }
                }
            }
            else
            {
                for (int j = 0; j < len_d2; j++)
                {
                    if (j == -1)
                    {
                        Console.WriteLine($"{array[i, j]}");
                    }
                    else
                    {
                        Console.Write($"{array[i, j]}");
                    }
                }
            }
        }
    }
}
