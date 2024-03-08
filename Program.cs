string[] InputArray(int num)
{
    string[] array = new string[num];
    for(int i = 0; i < num; i++)
    {
        System.Console.Write($"Input {i+1} element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write($"'{array[i]}', ");
    }
    System.Console.Write($"'{array[array.Length-1]}'");
}


string[] NewRow(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            count += 1;
        }
    }
    string[] newarray = new string[count];
    if (count == 0)
    {
        System.Console.WriteLine("New row is - []");
    }
    else
    {
        int n = 0;
        for(int j = 0; j < count; j++)
        {
            for(int i = n; i < array.Length; i++)
            {
                if(array[i].Length <= 3)
                {
                    n = i+1;
                    newarray[j] = array[i];
                    break;
                }
            }
        }
        System.Console.Write("New row is - [");
        PrintArray(newarray);
        System.Console.WriteLine("]");
    }
    return newarray;
}

System.Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

NewRow(InputArray(size));