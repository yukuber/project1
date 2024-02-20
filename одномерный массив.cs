using System;
class one_dim //класс одномерного массива
{
    private int len_one_dim; //длина массива
    private int[] array;
    private bool fill_rand = false;
    public one_dim (int len_one_dim)
    {
        array = new int[len_one_dim];

        Console.WriteLine("Заполнять массив рандомно? да или нет");
        string ans = Console.ReadLine();
        if (ans == "да")
        {
            fill_rand = true;
        }
        if (fill_rand)
        {
            one_dim_rand();
        }
        else
        {
            one_dim_manual();
        }
        print();
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
        
    public void pop100() //удаление всех чисел больше 100 по модулю
    {
        Console.WriteLine("укороченный");
        int kor_len = 0;
        int j = 0;
        foreach(int elem in array)
        {
            if (Math.Abs(elem)<=100)
            {
                kor_len ++;
            }
        }
        int[] kor_array = new int [kor_len];
        foreach(int l in array)
        {
            if (Math.Abs(l) < 100)
            {
                kor_array[j] = l;
                j ++;
            }  
            for (int i = 0; i< kor_array.Length;i++)
            {
                Console.Write(kor_array[i] + ", ");
            }
            Console.WriteLine();
        }
    }
    public void print()
    {
        foreach (int i in array)
        {
            Console.Write(i+", ");
        }
    }
}


