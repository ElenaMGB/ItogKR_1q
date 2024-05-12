using System;

class Program {
  public static void Main (string[] args) {
    // Создание массива для хранения строк
    string[] inputStrings;
    string[] filteredStrings;

    // Запрос ввода количества строк
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());

    // Инициализация массивов
    inputStrings = new string[n];
    filteredStrings = new string[n];
    
    // Заполнение массива строк пользователем
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите строку {i + 1}: ");
        inputStrings[i] = Console.ReadLine();
    }

    // Фильтрация строк по длине
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (inputStrings[i].Length <= 3)
        {
            filteredStrings[count] = inputStrings[i];
            count++;
        }
    }

    // Создание нового массива нужного размера
    string[] resultStrings = new string[count];

    // Копирование отфильтрованных строк в новый массив
    Array.Copy(filteredStrings, resultStrings, count);

    // Вывод результата
      string result = "";
      foreach (string str in resultStrings)
     {
                  result = result  + str + ",";
     } 
      Console.WriteLine("Строки длиной не более 3 символов:" + "[" + result + "]");
  }
}
