Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
int number = 0;
while (number < N-1)
{
number = number + 2;
Console.Write( number );
Console.Write( " " );
}