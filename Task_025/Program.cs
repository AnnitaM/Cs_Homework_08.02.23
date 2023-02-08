//Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Enter A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Enter B: ");
int B = int.Parse(Console.ReadLine());

Console.Write($"{A} raised to the power of {B} equals {ARaiseB(A)}");

int ARaiseB(int r)
{
    if (B < 0)
    {
        B *= (-1);
    }
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}
