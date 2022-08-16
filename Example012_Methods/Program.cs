// Первая группа методов - ничего не возвращают и ничего не принимают (аргументы)

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();


// Вторая группа методов - ничего не возвращают, но могут принимать аргуметны.
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg: "текст сообщения");
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//Method21("текст", 4);
//Method21(count: 4, msg: "новый текст");

// Третья группа методов - что-то возвращают но ничего не принимают

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// Четвертая группа - что-то возвращают и что-то принимают

// string Method4(int count, string text)
// {
//     string result = String.Empty; // " " - пустая строка  в начале
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10,"z");
// Console.WriteLine(res);


//  Вывод таблицы умножения на экран

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// Задача

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так крсноречивы. Вы дадите мне чаю?";

//  string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// } 
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'с', 'С');       
// Console.WriteLine(newText);


// int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array [i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);


// Сортировка от

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1, 8, 9, 10, 15, 14, 13, 20, 19, 18, 17, 16, 12, 11 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
Console.WriteLine();
PrintArray(arr);