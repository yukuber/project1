using System;
using System.Linq;
class one_dim //класс одномерного массива
{
    private int[] array;
    private static Random rand = new Random();

    public one_dim (int len_one_dim, bool fill_rand)
    {
        ReCreate(len_one_dim, fill_rand);
    }
    
    
    private void one_dim_rand ()
    {
        Random rnd = new Random();
        for (int i = 0; i<array.Length;i++)
        {
            array[i] = rnd.Next(-100,100);
        }
    }
    private void one_dim_manual()
    {
        for (int i = 0; i<array.Length; i++)
            {
                Console.WriteLine($"значение {i}:");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }
    }

    public void Print()
    {
        Print(array)
    }

    public void average() //вычисление среднего арифметического 
    {
        double sam = 0;
        foreach(int elem in array)
        {
            sam+=elem;
        }
        Console.WriteLine("среднее арифметическое");
        Console.WriteLine(sam/array.Length);
    }
        
    public int[] pop100() //удаление всех чисел больше 100 по модулю
    {
        Console.WriteLine("укороченный");
        foreach(int elem in array)
        {
            kor_array[i] = Math.Abs(array[i]) < 100
                ? array[i]
                : int.MinValue;

            
        //int[] kor_array = new int [kor_len];
        //return kor_array;
            Print(kor_array)
    }

    private static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == int.MinValue)
            {
                continue;
            }
            Console.Write($"{array[i]} ")
        }
        Console.WriteLine();            
    }
        
    public int[] non_repeat()
    {
        int[] unique = array.Distinct().ToArray();

        Print(unique);
    }
        
    
    public void ReCreate (int len_one_dim, bool fill_rand)
    {
        array = new int[len_one_dim];

        if (fill_rand)
        {
            one_dim_rand();
        }
        else
        {
            one_dim_manual();
        }
    }
    }


