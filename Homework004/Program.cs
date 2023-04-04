// Задача 25
Console.Clear();

int numA(){
    Console.Write("Введите число А: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numB(){
    Console.Write("Введите число B: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numberA = numA();
int numberB = numB();

int NumPow(){
    int result = 1;
    for (int count = 0; count < numberB; count++)
    {
        result = result * numberA;
    }
    return result;
}

Console.WriteLine($"Результат возведения числа {numberA} в степень {numberB} -> {NumPow()}");

// Задача №27

int NumUser()
{
    Console.Write("Введите чило для подсчета суммы числе в числе: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumNumUser(int numberX)
{
    int result = 0;
    while (numberX > 0)
    {
        result = result + (numberX % 10);
        numberX = numberX / 10;
    }
    return result;
}

int number = NumUser();
Console.Write($"Сумма чисел в числе {number} = {SumNumUser(number)}");

// Задача №29

int sizeArray = 8;
int[] array = new int[sizeArray];

int[] RandomNumberArray(int[] arrayUser){
    for (int i = 0; i < arrayUser.Length; i++)
    {
        arrayUser[i] = new Random().Next(10, 100);
    }
    return arrayUser;
}

void PrintArray(int[] arrayUser){
    for (int i = 0; i < arrayUser.Length; i++)
    {
        Console.Write($"{arrayUser[i]} ");
    }
}


RandomNumberArray(array);
PrintArray(array);