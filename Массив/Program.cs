/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.*/

void printResult(int arrSize)
{
    string[] usArray = userArray(arrSize);
    Console.WriteLine($"\nUser array: {String.Join(", ", usArray)}");
    string[] resArr = resArray(usArray);
    Console.WriteLine($"Result array: {String.Join(", ", resArr)}");
}

string[] userArray(int size)
{
    string[] array_01 = new string[size];
    for(int idx = 0; idx < size; idx++)
    {
        Console.WriteLine($"Enter {idx + 1} element: ");
        string nxtEl = Console.ReadLine();
        if(nxtEl.Length < 1)
        {
            Console.WriteLine("Lenght element < 1, пробуй еще раз!");
            idx -= 1;
            continue;
        }
        else 
        {
            array_01[idx] = nxtEl;
        }
    }
    return array_01;
}

string[] resArray(string[] userArray)
{
    string[] arrayRes = new string[0];
    for(int idx = 0; idx < userArray.Length; idx++)
    {
        if(userArray[idx].Length <= 3)
        {
            arrayRes = arrayRes.Concat(new string[] {userArray[idx]}).ToArray();
        }
    }
    return arrayRes;
}

int nextElArrSize(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    int num = 0;
    while(resVal == false || num < 0)
    {
        string elem = Console.ReadLine();
        resVal = Int32.TryParse(elem, out num);
        if(resVal == false || num < 0)
        {
            Console.WriteLine("Введена ошибка! Прбуй еще!");
        }
    }
    return num;
}

while(true)
{
    Console.Write("\n");
    Console.WriteLine("\nEnter 's' to start or enter 'q' to stop: ");
    string usrQuest = Console.ReadLine();
    if(usrQuest.ToLower() == "q")
    {
        Console.WriteLine("Пока!");
        break;
    }
    else if(usrQuest.ToLower() == "s")
    {
        int arrSize = nextElArrSize("Enter array size: ");
        printResult(arrSize);
    }    
}