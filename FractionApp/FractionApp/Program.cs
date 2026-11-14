using FractionApp;

object ob = new Object();

Fraction f = new Fraction();

Fraction f2 = new Fraction(-2,-3);

Fraction f3 = new Fraction(-20);

int x = 5, k = 8;


Console.WriteLine("f");
f.ShowFrac();

f.SetChisl(4);
f.SetZnam(5);

f.ShowFrac();

Console.WriteLine("f2");

f2.ShowFrac();

f2.Chis = 5;
f2.Znam = -15;

f2.ShowFrac();


//Console.WriteLine(f2.Equals(f));
Console.WriteLine($"f2 = {f2}");
//f3 = f;
//f.Chis = 56;
Console.WriteLine($"f3 = {f3}");
Console.WriteLine(f2.GetType());


Console.WriteLine($"k = {k} x = {x}");
k = x;
x = 7;
Console.WriteLine($"k = {k} x = {x}");
