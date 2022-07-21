void Ex_001()
{

//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.WriteLine ("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());
int count=1;
int result=1;

for (int i = 1; count <= B; count++)
{
    i*=A;
    result=i;
}

Console.WriteLine($"{A} в степени {B} = {result}");
}

//Ex_001();
