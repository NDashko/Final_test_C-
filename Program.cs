// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] arrayStart = new string[4] {"hello","2","world",":-)"};
string[] arrayResult = new string[arrayStart.Length];

string[] SecondArrayWithIF(string[] arrayStart, string[] arrayResult)
{
    int temp = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
    if(arrayStart[i].Length <= 3)
        {
        arrayResult[temp] = arrayStart[i];
        temp++;
        }
    }
    return arrayResult;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
}

arrayResult = SecondArrayWithIF(arrayStart, arrayResult);
PrintArray(arrayResult);