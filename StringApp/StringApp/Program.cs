using System.Text;

string str1 = "Жbc 1dEЦf", str2 = "x5yzghk4"; 

//string str = @"abc \1dEЦf"       // игнорируем управляющие символы
str1 = str1 + str2;  // конкатенация строк

for (int i = 0; i < str1.Length; i++)
{
    char ch1 = str1[i];
    int d = (int)ch1;
    Console.WriteLine($"код {ch1} = {d}");
}

int k = 1065;
char ch2 = (char)k;
Console.WriteLine($" символ {k} = {ch2} ");


//Console.WriteLine(str1);

char ch;
for(int i = 0; i < str1.Length; i++)  // цикл по строке
{
    ch = str1[i];
    if(Char.IsDigit(ch) || !Char.IsLetter(ch) ||  // функции символьного типа 
        Char.IsUpper(ch))
        Console.WriteLine(ch);
}

//Console.WriteLine(str1[str1.Length]); index out of range

string s = Console.ReadLine();

//int k = Convert.ToInt32(s);     // класс для конвертации типов
//int k = int.Parse(s);        // парсинг строки в конкретный тип
//double x = 45.45;
// Console.WriteLine(k);

int sum = 0;
foreach (string c1 in s.Split(' '))
{
    sum += int.Parse(c1);
}
Console.WriteLine($"sum={sum} "); //форматированная строка 

int[] arr = { 1, 2, 3, 5, 6, 7, -6, 4, 6, 34, 67 };

StringBuilder sb = new StringBuilder();
for(int i=0; i<arr.Length; i++)
{
    sb.Append(Convert.ToString(arr[i])+' ');
}
var arrs = sb.ToString();

Console.WriteLine(arrs);


