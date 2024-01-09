//int n = 10;
int[] arry = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
int i = 0;

while (i < arry.Length) 
{
    if (arry[i] % 2 == 0)
    {
        Console.Write($"{arry[i]} ");
    }
    i = i + 1;
}