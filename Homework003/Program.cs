// Задача №19
Console.Clear();

Console.Write("Введите пятизачное число: ");
int numUser = Convert.ToInt32(Console.ReadLine());
int number = numUser; 
int discharge = 10000;
int count = 0;
int result = 0;

while (count < 5){
    int numDischarge = number % 10;
    number = number / 10;
    count++;
    int numOne = numDischarge * discharge;
    result = result + numOne;
    discharge = discharge / 10;
}
if(result == numUser){
    Console.WriteLine("Число является палиндромом");
}
else{
    Console.WriteLine("Число не является палиндромом");
}

// Задача №21
Console.Clear();
Console.WriteLine("Введите кординату x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine(Math.Round(result, 2));

// Задача №23
Console.Clear();
Console.Write("введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count <= numN){
    Console.WriteLine(Math.Pow(count, 3));
    count++;
}