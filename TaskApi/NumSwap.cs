// Swapping of Num,bers without using third variable

int a = 5, b = 7;

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine($"a = {a}, b = {b}");