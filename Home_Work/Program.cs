// Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа кратные 3-ём в промежутке от M до N.
void Zadacha64()
{
    Console.WriteLine("Введите первое число ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе чило ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("В данном промежутке находятся следующие числа, кратные трем:");
    Rec(M, N);
}

// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
void Zadacha66()
{
    Console.WriteLine("Введите первое число ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе чило ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сумма чисел в данном промежутке равна:");
    Sum(M, N);
}

// Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n. 
void Zadacha68()
{
    Console.WriteLine("Введите первое число ");
    double m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе чило ");
    double n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Функция Аккермана равна:");
    Console.WriteLine(A(m, n));
}

void Rec(int M, int N)
{
    if (M > N) return;
    else
    {
        if (M % 3 == 0) Console.WriteLine(M);                     
        M++;            
    }
    Rec(M, N);   
}

void Sum(int M, int N, int sum = 0)
{
    if (M > N) 
    {
        Console.WriteLine(sum);
        return;
    }
    else
    {
        sum = sum + M;                     
        M++;            
    }
    Sum(M, N, sum);          
}

double A(double m, double n)
{
    if (m == 0) return n + 1;
    else
    if ((m != 0) && (n == 0)) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));        
}

//Zadacha64();
//Zadacha66();
Zadacha68();