using System;
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
    }
    
    d1 array1 = new(a1, fill_rand);

    if (fill_rand)
    {
        array1.d1_rand(a1);
    }
    else
    {
        array1.d1_manual(a1);
    }
        array1.average();
        array1.pop100();


    bool fill_rand2 = false;
    Console.WriteLine("Заполнять массив рандомно? да или нет");
    string ans2 = Console.ReadLine();
    if (ans2 == "да")
    {
        fill_rand2 = true;
    }

    Console.WriteLine("Введите высоту массива");
    int high_d2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите длину массивов");
    int len_d2 = int.Parse(Console.ReadLine());

    d2 array2 = new d2(high_d2, len_d2, fill_rand);

    if (fill_rand2)
    {
        array2.d2_rand(high_d2,len_d2);
    }
    else
    {
        array2.d2_manual(high_d2,len_d2);
    }

}
