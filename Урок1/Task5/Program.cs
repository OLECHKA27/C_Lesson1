int N =9;
for (int A =0; A<=N; A++)
{Console.WriteLine($"Ряд натуральных чисел от 1 до {N}:+{A+1}");}


int L = 9;
string result = string.Empty;

for (int i = 1; i <= L; i++)
{
    if (i != 1)
        result += ", ";
    
    result += i.ToString();
}

Console.WriteLine(result);

int T = 11;
int S = 1;
while (S <= T)
{
    Console.Write(S);
    Console.Write(' ');
    S++;
}

