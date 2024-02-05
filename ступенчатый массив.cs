using System;

class d3
{
    private int high_d3;
    private int[][] array3;
    public d3(int high_d3, bool fill_rand)
    {
        array3 = new int[high_d3][];
        if (fill_rand == true)
        {
            Random rnd = new Random();
            for (int i = 0; i < high_d3; i++)
            {
                for (int j = 0; j < rnd.Next(1, 10); j++)
                {
                    array3[i][j] = rnd.Next(-100,100);
                }
            }
        }
        else
        {
            for (int i = 0; i < high_d3 ; i++)
            {
                Console.WriteLine($"Введите длину подмассива {i}");
                int len_each_d3 = int.Parse(Console.ReadLine());
                for (int j = 0; j < len_each_d3 ; j++)
                {
                    Console.Write($"Элемент [{i}],[{j}]: ");
                    array3[i][j] = int.Parse(Console.ReadLine());
                }    
            }
        }
    }
    public void average_d3()
    {
        int sum = 0;
        for (int i = 0; i < high_d3; i++)
        {
            for (int j = 0; j < array3[i].Length; j++)
            {
                sum += j;
            }
        }
        Console.WriteLine($"среднее значение в массиве {sum}");
    }
    public void average_each_d3()
    {
        for (int i = 0; i < high_d3; i++)
        {
            int sum = 0;
            for (int j = 0; j < array3[i].Length; j++)
            {
                sum += j;
                Console.WriteLine($"среднее значение в подмассиве {i} = {sum}");
            }
        }
    }
    public void muliply_d3()
    {
        for (int i = 0; i < high_d3; i++)
        {
            for (int j = 0; j < array3[i].Length; j++)
            {
                Console.WriteLine("");
                if (j%2==0)
                {
                   Console.Write(i*j);
                }
                else
                {
                    Console.Write(array3[i][j]);
                }
                
            }
        }
        
    }
}


