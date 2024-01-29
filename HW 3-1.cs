using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите длину одномерного массива:");
        int a1 = int.Parse(Console.ReadLine());

        bool fill_rand = false;
        Console.WriteLine("Заполнять массив рандомно? да или нет");
        string ans = Console.ReadLine();
        if (ans == "да")
        {
            fill_rand = true;
            array1.d1_rand();
        }
        d1 array1= new d1(a1, fill_rand);

        array1.average();
        array1.pop100();
    }
}
class d1 //класс одномерного массива
{
    private int len_d1; //длина массива
    public int[] array;
    public d1 (int len_d1, bool fill_rand)
    {
        array = new int[len_d1];
        
    }
    private d1_rand (int len_d1)
    {
        Random rnd = new Random();
        for (int i = 0; i<len_d1;i++)
        {
            array[i] = rnd.Next(-100,100);
        }
        print();
    }
    private d1_manual()
    {
        for (int i = 0; i<len_d1; i++)
            {
                Console.WriteLine($"значение {i}:");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }
        print();
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


