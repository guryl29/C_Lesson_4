// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Vvedite chislo: ");
int a= int.Parse(Console.ReadLine());
int sum = 0;
int num=0;
while( a > 0)
    {
        num = a%10;
        sum=sum+num;
        a=a/10;

    }

Console.WriteLine(sum);