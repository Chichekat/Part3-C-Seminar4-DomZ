//  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
// в числе. 452 -> 11; 82 -> 10; 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
String number = num.ToString();
int [] array = new int[number.Length];
Console.WriteLine($"{num} -> {GetSumNumbers(num)} ");

int GetSumNumbers (int num){
    int result = 0;
    while (num > 0){
        result += num % 10;
        num /= 10;
    }
    return result;
}