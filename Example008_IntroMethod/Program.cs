int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 34;
int b1 = 56;
int c1 = 79;
int a2 = 49;
int b2 = 570;
int c2 = 79;
int a3 = 366;
int b3 = 6;
int c3 = 71;

int max1 = Max(a1, b1, c1);
Console.WriteLine($"max1 = {max1}");
int max2 = Max(a2, b2, c2);
Console.WriteLine($"max2 = {max2}");
int max3 = Max(a3, b3, c3);
Console.WriteLine($"max3 = {max3}");

int max = Max(max1, max2, max3);
Console.WriteLine($"max = {max}");