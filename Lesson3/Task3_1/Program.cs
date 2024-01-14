double CalkulateFormula(int a, int b, int c, int d)
{
    double numinater = a * b;
    int denominator = c + d;
    double result = numinater / denominator;
    return result;
}
double result = CalkulateFormula(1, 2, 3, 4);
Console.WriteLine(result);