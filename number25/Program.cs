//Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
    
Console.WriteLine("Vvedite chislo");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite chislo");
int b = int.Parse(Console.ReadLine());

double res = Math.Pow(a, b);
Console.WriteLine(res);
