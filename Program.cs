// ## Итоговая проверочная работа.

// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. 
// Мы должны убедиться что базовое знакомство с it прошло успешно.

// Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, 
// как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


// РЕШЕНИЕ
//метод возвращает массив элементов заполненный пользователем через консоль
string[] arrStart()
{
    int count = 0;
    const int N = 0;
    string element;
    string? elementStringArr = "";

startProgramm:

    //Заполняем строку будущими элементами массива и выясняем длину будущего массива
    while (N == 0)
    {
        Console.WriteLine("Введите значение и нажмите Enter 1 раз для ввода следующего значения, для завершения нажмите Enter 2 раза");
        element = Console.ReadLine();

        if (element == "")
        {
            int chrEnd = elementStringArr.Length - 1;
            elementStringArr = elementStringArr.Remove(chrEnd);
            break;
        }
        else
        {
            elementStringArr += element + "/";
            count++;
        }
    }
    // Проверка на первый ввод
    if (count == 0 && element == "") 
    {
        Console.WriteLine("Вы ничего не ввели.\n");
        goto startProgramm;
    }
    //Перезаписываем строку с будущими элементами массива в массив
    string[] arr = new string[count];

    // Если введён один элемент, то записываем его значение напрямую в массив
    if (count == 1) arr[0] = elementStringArr;
    else arr = elementStringArr.Split("/").ToArray();

    return arr;

}

//Определяем количество элементов массива c длиной строк <= n (по условию задачи <=3)
int arrLen(string[] arr, int n)
{   int count = 0;
    for(int i=0;i<arr.Length;i++)
    {
        if(arr[i].Length <= n) count++;
    }
    return count;
}


//Формируем массив из строк длинной меньше или равной n
string[] arraySort(string[] arr, int massLen, int countLen)
{   int j = 0;
    string[] arrSorting = new string[massLen];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= countLen)
        {
            arrSorting[j] = arr[i];
            j++;
        }
    }
    return arrSorting;
}

//Выводим массив
void arrayPrint(string[] arr)
{
    string a = string.Join(",",arr);
    Console.WriteLine("Полученный массив:\n");
    Console.WriteLine("[" + a + "]\n");
}


//Сборка

//инициализируем массив данных по условию задачи
string[] arrayX = arrStart();

//Выводим полученный массив для нагядности
arrayPrint(arrayX);

//Инициализируем отсортированный массив
int num = arrLen(arrayX , 3);
string[] arrSortTask = arraySort(arrayX, num, 3);


//Выводим ответ задачи
Console.WriteLine("ОТВЕТ задачи:\n");
arrayPrint(arrSortTask);