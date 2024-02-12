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

    one_dim array1 = new(a1);

    array1.average();
    array1.pop100();
}
static void dim_two()
{
    Console.WriteLine("Введите высоту массива");
    int high_d2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите длину массивов");
    int len_d2 = int.Parse(Console.ReadLine());

    two_dim array2 = new(high_d2, len_d2);

    array2.average_d2();
    array2.obr_chet();
}
static void dim_three()
{
     Console.WriteLine("Введите высоту массива");
    int high_d3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите длинe одномерных массивов");
    int len_d3 = int.Parse(Console.ReadLine());

    three_dim array3 = new(high_d3);

    array3.average_three_dim();
    array3.average_each_three_dim();
    array3.muliply_three_dim();
}