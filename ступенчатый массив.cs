using System;

class three_dim
{
    private int[][] array3;

    public three_dim(int high_three_dim, bool fill_rand)
    {
        ReCreate(high_three_dim, fill_rand)

    }
    private void three_dim_rand()
    {
        Random rnd = new Random();
        for (int i = 0; i < array3.Length; i++)
        {
            for (int j = 0; j < rnd.Next(1, 10); j++)
            {
                array3[i][j] = rnd.Next(-100, 100);
            }
        }
    }
    private void three_dim_manual()
    {
        for (int i = 0; i < array3.Length; i++)
        {
            Console.WriteLine($"Введите длину подмассива {i}");
            int len_each_three_dim = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < len_each_three_dim; j++)
            {
                Console.Write($"Элемент [{i}],[{j}]: ");
                array3[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    public void average_three_dim()
    {
        int sum = 0;
        for (int i = 0; i < array3.Length; i++)
        {
            for (int j = 0; j < array3[i].Length; j++)
            {
                sum += j;
            }
        }
        Console.WriteLine($"среднее значение в массиве {sum / array3.Length}");
    }

    public void average_each_three_dim()
    {
        for (int i = 0; i < array3.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < array3[i].Length; j++)
            {
                sum += j;
                Console.WriteLine($"среднее значение в подмассиве {i} = {sum / array3[i].Length}");
            }
        }
    }

    public void muliply_three_dim()
    {
        for (int i = 0; i < array3.Length; i++)
        {
            for (int j = 0; j < array3[i].Length; j++)
            {
                Console.WriteLine("");
                if (j % 2 == 0)
                {
                    Console.Write(i * j);
                }
                else
                {
                    Console.Write(array3[i][j]);
                }

            }
        }

    }
    public void ReCreate(int high_three_dim, bool fill_rand)
    {
        array3 = new int[high_three_dim][];

        if (fill_rand)
        {
            three_dim_rand();
        }
        else
        {
            three_dim_manual();
        }
    }
}


