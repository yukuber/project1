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
