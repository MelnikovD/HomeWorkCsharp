int a, b;

Console.Write("Input number a:  ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number b:  ");
b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine(a);
}
else
{
Console.WriteLine(b);
}

Console.WriteLine("Task 2");
int c, d, e, max;

Console.Write("Input number c:  ");
c = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number d:  ");
d = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number e:  ");
e = Convert.ToInt32(Console.ReadLine());

max = c;

if (d>c)
{
    max = d;
}
else
{
max=c;
}

if (e>max)
{
max=e;
}
else
{
  Console.WriteLine("MAX is " + max);  
}


Console.WriteLine("Task 3");

int f;

Console.WriteLine("Input number f:  ");
f = Convert.ToInt32(Console.ReadLine());

if ( (f % 2) == 0)
{
    Console.WriteLine("да");
}
else
{
Console.WriteLine("нет");
}

