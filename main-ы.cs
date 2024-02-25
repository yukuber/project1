using System;

static void Main()
{ 
    dim_one();

    dim_two();

    dim_three();
}
static void dim_one()
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
    
    one_dim array1 = new(a1, fill_rand);

    array1.average();
    array1.pop100();
    array1.non_repeat();
        
}
static void dim_two()
{
    Console.WriteLine("Введите высоту массива");
    int high_d2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите длину массивов");
    int len_d2 = int.Parse(Console.ReadLine());

    bool fill_rand = false;

    Console.WriteLine("Заполнять массив рандомно? да или нет");
    string ans = Console.ReadLine();
    if (ans == "да")
    {
        fill_rand = true;
    }

    two_dim array2 = new(high_d2, len_d2, fill_rand);

    array2.average_d2();
    array2.obr_chet();
}
static void dim_three()
{
    Console.WriteLine("Введите высоту массива");
    int high_d3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите длинe одномерных массивов");
    int len_d3 = int.Parse(Console.ReadLine());

    bool fill_rand = false;

    Console.WriteLine("Заполнять массив рандомно? да или нет");
    string ans = Console.ReadLine();
    if (ans == "да")
    {
        fill_rand = true;
    }

    three_dim array3 = new(high_d3, fill_rand);

    array3.average_three_dim();
    array3.average_each_three_dim();
    array3.muliply_three_dim();
}