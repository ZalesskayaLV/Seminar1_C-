Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number==1)
{
    Console.Write(number);
    Console.WriteLine(" -> понедельник");
}

if(number==2)
{
    Console.Write(number);
    Console.WriteLine(" -> вторник");
}

if(number==3)
{
    Console.Write(number);
    Console.WriteLine(" -> среда");
}

if(number==4)
{
    Console.Write(number);
    Console.WriteLine(" -> четверг");
}

if(number==5)
{
    Console.Write(number);
    Console.WriteLine(" -> пятница");
}

if(number==6)
{
    Console.Write(number);
    Console.WriteLine(" -> суббота");
}

if(number==7)
{
    Console.Write(number);
    Console.WriteLine(" -> воскресенье");
}

if(number>7)
{
    Console.WriteLine("неверное число");
}