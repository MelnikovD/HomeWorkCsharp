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
  Console.Write("MAX is" + max);  
}

