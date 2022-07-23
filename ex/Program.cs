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

Ex_001();

void Ex_002()
{
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

}

//Ex_002();

void Ex_003()
{
    //Напишите программу, которая задаёт массив из 8 элементов 
    //и выводит отсортированный по модулю массив.

    Random random=new Random();
    int size=random.Next(1,8);
    int[] array= new int[size];

        
        Console.Write("{");

        for (int i=0;i<array.Length; i++)
            {
                array[i]= random.Next(-10,1);
                Console.Write(array[i]+", ");
            }
            
            Console.Write("\b\b}");
            Console.WriteLine();

            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[i]) > Math.Abs(array[j]))
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    else if ((Math.Abs(array[i]) == Math.Abs(array[j])) && (array[i] > array[j]))
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
    

            Console.Write("[");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.Write("\b\b]");
            Console.WriteLine();
}

Ex_003();


