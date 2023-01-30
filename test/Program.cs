// Собрать строку с числами от a до b, a ≤ b

Console.Clear();

string NumbersFor(int a, int b)
{
string result = String.Empty;
for (int i = a; i <= b; i++)
{
result += $"{i} ";
}
return result;
}
string NumbersRec(int a, int b)
{
if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10






Console.Clear();

// Собрать строку с числами от a до b, a ≥ b

string NumbersFor(int a, int b)
{
string result = String.Empty;
for (int i = a; i >= b; i--)
{
result += $"{i} ";
}
return result;
}
string NumbersRec(int a, int b)
{
if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1

   




Console.Clear();

// Сумма чисел от 1 до n

int SumFor(int n)
{
int result = 0;
for (int i = 1; i <= n; i++) result += i;
return result;
}
int SumRec(int n)
{
if (n == 0) return 0;
else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55




Console.Clear();

// Факториал числа

int FactorialFor(int n)
{
int result = 1;
for (int i = 1; i <= n; i++) result *= i;
return result;
}
int FactorialRec(int n)
{
if (n == 1) return 1;
else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800



Console.Clear();

// Вычислить а в степени n

int PowerFor(int a, int n)
{ int result = 1;
for (int i = 1; i <= n; i++) result *= a;
return result;
}
int PowerRec(int a, int n)
{ return n == 0 ? 1 : PowerRec(a, n - 1) * a;
if (n == 0) return 1;
else return PowerRec(a, n - 1) * a;
}
int PowerRecMath(int a, int n)
{
if (n == 0) return 1;
else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024




Console.Clear();

// Перебор слов

char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
 for (int j = 0; j < count; j++)
 {
   for (int k = 0; k < count; k++)
   {
    for (int l = 0; l < count; l++)
    {
     for (int m = 0; m < count; m++)
      {
        Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
      }
    }
   }
 }
}




Console.Clear();

// Есть 5 игроков
// Нужно показать все разбиения игроков на две команды
// 0 - игрок попадает в первую команду
// 1 - игрок попадает во вторую команду

void FindWords(string alphabet, char[] word, int length = 0)
{
if (length == word.Length)
{
Console.WriteLine($"{n++} {new String(word)}"); return;
}
for (int i = 0; i < alphabet.Length; i++)
{
word[length] = alphabet[i];
FindWords(alphabet, word, length + 1);
}
}
FindWords(“аисв”, new char[5]);




Console.Clear();

// Как посмотреть содержимое папки?

void CatalogInfo(string path, string indent = "")
{
DirectoryInfo catalogs = new DirectoryInfo(path);
foreach (var currentCatalog in catalogs.GetDirectories())
{
Console.WriteLine($"{indent}{currentCatalog.Name}");
CatalogInfo(currentCatalog.FullName, indent + " ");
}
foreach (var item in catalogs.GetFiles())
{
Console.WriteLine($"{indent}{item.Name}");
}
}
string path = @"/Users/sergejkamaneckij/Projects/HelloCode";
CatalogInfo(path);




Console.Clear();

// Игра в пирамидки

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
if (count > 1) Towers(with, some, on, count - 1);
Console.WriteLine($"{with} >> {on}");
if (count > 1) Towers(some, on, with, count - 1);
}





Console.Clear();

// Обход разных структур

string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// 0 1 2 3 4 5 6 7 8 9 10 11
void InOrderTraversal(int pos = 1)
{
if (pos < tree.Length)
{
int left = 2 * pos;
int right = 2 * pos + 1;
if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
Console.WriteLine(tree[pos]);
if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
}
}



Console.Clear();

void OutputNumbers(int n)
{
if (n >= 1) {
OutputNumbers(n - 1);
Console.WriteLine(n);
}
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

OutputNumbers(n);




Console.Clear();

void OutputNumbers(int n, int m)
{
if (n >= m) {
OutputNumbers(n - 1,m);
Console.WriteLine(n);
}

}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n>m)
{
OutputNumbers(n, m);
}
if (m>n)
{
OutputNumbers(m, n);
}
if (m==n)
{
Console.Write("Числа равны ");
}




Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(1,n);

void PrintNumbers(int start, int end)
{
Console.Write($"{start} ");
if (start == end) return;
PrintNumbers(start + 1, end);
}



Console.Clear();
void OutputNumbers(int n, int m)
{

if (n >= m) {
OutputNumbers(n - 1,m);
Console.WriteLine(n);
}

}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n>m)
{
OutputNumbers(n, m);
}
if (m>n)
{
OutputNumbers(m, n);
}
if (m==n)
{
Console.Write("Числа равны ");
}



Console.Clear();
Console.Write("Введите число: ");
int num = Math.Abs( int.Parse(Console.ReadLine()));

Console.WriteLine("Сумма цифр числа:"+Sum(num));
int Sum(int inputNum)
{
if (inputNum < 10) return inputNum;
else return inputNum % 10 + Sum(inputNum / 10);
}



Console.Clear();
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"{Pow(m,n)}");

int Pow(int number,int rank)
{
if (rank == 0) return 1;
else return (number * Pow(number,rank-1));
}
