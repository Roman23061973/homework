// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine9);
if (number>=100 $ number<1000)

{

    int digit2 = (number % 100)/10;
    Console.WriteLine($"Вторая цифра этого числа.");
}

else

{

    Console.WriteLine("Error. Введите трехзначное число.");
}