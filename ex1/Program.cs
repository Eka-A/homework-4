    //Напишите программу, которая принимает на вход число 
    //и выдаёт сумму цифр в числе.

    Console.WriteLine ("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum=0;
    int count=number;
    int result=0;

    while (count<=number)
    {
        if (count!=0)
        {
        result=count%10;
        sum+=result;
        count/=10;
        }
        else
        {
            Console.Write($"Сумма чисел = {sum}");
            break;
        }
        
    }



