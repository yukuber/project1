using System;
using System.Linq;
class one_dim //класс одномерного массива
{
    private int[] array;

    public one_dim (int len_one_dim, bool fill_rand)
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

    public void average() //вычисление среднего арифметического 
    {
        double sam = 0;
        foreach(int elem in array)
        {
            sam+=elem;
        }
        Console.WriteLine("среднее арифм");
        Console.WriteLine(sam/array.Length);
    }
        
    public int[] pop100() //удаление всех чисел больше 100 по модулю
    {
        Console.WriteLine("укороченный");
        int kor_len = 0;
        foreach(int elem in array)
        {
            if (Math.Abs(elem)<=100)
            {
                kor_len ++;
            }
        }
        int[] kor_array = new int [kor_len];
        return kor_array;
    }
    public int[] non_repeat()
    {
        int[] unique = array.Distinct().ToArray();

       
        return unique;
    }
    public void print(int[] array, int[] kor_array, int[] unique)
    {
        
        Console.WriteLine("изначальный массив");
        Console.WriteLine(string.Join(" ", array));


        Console.WriteLine("только элементы меньше 100");
        Console.WriteLine(string.Join(" ", kor_array));

        Console.WriteLine("массив без повторений");
        Console.WriteLine(string.Join(" ", unique));
    }
}


