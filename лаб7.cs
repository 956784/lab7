Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строку");
string S = Console.ReadLine();
if (S.Length > N)
    S = S.Substring(S.Length - N, N);
else
    S = new string('.', N - S.Length) + S;
Console.WriteLine(S);