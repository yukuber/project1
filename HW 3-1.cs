using System;
class HelloWorld
{
    static void Main()
    {
        bool fill_rand = false;
        Console.WriteLine("Заполнять все массивы рандомно? да или нет");
        string ans = Console.ReadLine();
        if (ans == "да")
        {
            fill_rand = true;
        }
        Console.WriteLine("Введите длину одномерного массива:");
        int a1 = int.Parse(Console.ReadLine());

        d1 array1= new d1(a1, fill_rand);    
        array1.average();
        array1.pop100();
        
        Console.WriteLine("Введите высоту двумерного массива:");
        int y2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите длину двумерного массива:");
        int x2 = int.Parse(Console.ReadLine());

        d2 array2 = new d2(y2, x2, fill_rand);
        array2.average_d2();
        array2.obr_chet();

        Console.WriteLine("Введите количестово массивов в ступенчатом массиве");
        
        int high_d3 = int.Parse(Console.ReadLine());
        d3 array3 = new d3(high_d3, fill_rand);

    }
}
class d1 //класс одномерного массива
{
    private int len_d1; //длина массива
    public int[] array;
    public d1 (int len_d1, bool fill_rand)
    {
        array = new int[len_d1];
        if (fill_rand == true)
        {
            Random rnd = new Random();
            for (int i = 0; i<len_d1;i++)
            {
                array[i] = rnd.Next(-100,100);
            }
        }
        else
        {
            for (int i = 0; i<len_d1; i++)
            {
                Console.WriteLine($"значение {i}:");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }
        }
        foreach (int i in array)
        {
            Console.Write(i+", ");
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
}

class d2
{
    private int high_d2;
    private int len_d2;
    public int[,] array2;
    public d2 (int high_d2, int len_d2, bool fill_rand)
    {
        array2 = new int[high_d2,len_d2];
        if (fill_rand == true)
        {
            Random rnd = new Random();
            for (int i = 0; i < high_d2; i++)
            {
                for (int j = 0; j < len_d2; j++)
                {
                    array2[i, j] = rnd.Next(-100,100);
                }
            }
        }
        else
        {
            for (int i = 0; i < high_d2; i++)
            {
                for (int j = 0; j < len_d2; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                }    
            }
        }
    }
    
    public void average_d2()
    {
        int sam = 0;
        foreach(int elem in array2)
        {
            sam+=elem;
        }
        Console.WriteLine($"средн арифм в двумерном массиве " + sam);
    }
    
    public void obr_chet()
    {
        for (int i = 0; i<high_d2; i++)
        {
            if ((i+1)%2==0)
            {
                for (int j = len_d2-1; j>=0; j--)
                {
                    if (j==0)
                    {
                        Console.WriteLine($"{array2[i,j]}");
                    }
                    else
                    {
                        Console.Write($"{array2[i,j]}");
                    }
                }
            }
            else
            {
                for (int j = 0; j<len_d2; j++)
                {
                    if (j==-1)
                    {
                        Console.WriteLine($"{array2[i,j]}");
                    }
                    else
                    {
                        Console.Write($"{array2[i,j]}");
                    }
                }
            }
        }
    }
}

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
//     public void average_d3()
//     {
//         int sum = 0;
//         for (i=0; i<high_d3; i++)
//         {
//             for (j=0; j< array3.Length[i]; j++)
//             {
//                 sum+=j;
//             }
//         }
//     }
}


