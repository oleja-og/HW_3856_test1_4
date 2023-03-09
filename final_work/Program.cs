// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символа. 


string[] massiv1 = {"hello","2","world",":-)"};
string[] massiv2 = {"1234","1567","-2","computer science"};
string[] massiv3 = {"Russia","Denmark","Kazan"};


string[] EnterArray(string[] array)
{
    // Находим кол-во строк удовлетворяющих условию
    // Чтобы задать величину выхдного массива
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        {
           count++;
        }
    }
    
    // Записываем строки в выходной массив
    string[] massiv = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        {
           massiv[j] = array[i];
           j++;
        }
    }
    return massiv;
}


void Tusk()
{
        string[] massiv = EnterArray(massiv1);
        Console.WriteLine("[{0}]", string.Join(",",massiv));
        Console.WriteLine();
        massiv = EnterArray(massiv2);
        Console.WriteLine("[{0}]", string.Join(",",massiv));
         Console.WriteLine();
        massiv = EnterArray(massiv3);
        Console.WriteLine("[{0}]", string.Join(",",massiv));
}


Tusk();
