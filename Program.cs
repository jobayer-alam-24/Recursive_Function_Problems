namespace Recursive_Function_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"======Recursive Function Problems======");
            PrintNameNTimes(5, "Sheikh Jobayer Alam");
            NewL();
            TenToOne(10);
            NewL();
            OneToTen(1);
            NewL();
            TenEven(2);
            NewL();
            TenOdd(1);
            NewL();
            TenToHundred(10);
            NewL();
            HunderedToTen(100);
        }
        static void PrintNameNTimes(int n, string name)
        {
            if(n == 0)
            {
                return;
            }
            Console.WriteLine(name);
            PrintNameNTimes(n - 1, name);
        }
        static void HunderedToTen(int n)
        {
            Console.Write($"{n} ");
            if(n == 10)
            {
                return;
            }
            HunderedToTen(n - 10);
        }
        static void TenToHundred(int n)
        {
            Console.Write(n + " ");
            if(n == 100)
            {
                return;
            }
            TenToHundred(n + 10);
        }
        static void TenOdd(int n)
        {
            if(n % 2 != 0)
            {
                Console.Write(n + " ");
            }
            if(n == 10)
            {
                return;
            }
            TenOdd(n + 1);
        }
        static void TenEven(int n)
        {
            if(n % 2 == 0)
            {
                Console.Write(n + " ");
            }
            if(n == 10)
            {
                return;
            }
            TenEven(n + 1);
        }
        static void OneToTen(int n)
        {
            Console.Write($"{n} ");
            if(n == 10)
            {
                return;
            }
            OneToTen(n + 1);
        }
        static void TenToOne(int n)
        {
            if(n == 0)
            {
                return;
            }
            Console.Write(n + " ");
            TenToOne(n - 1);
        }
        static void NewL()
        {
            Console.WriteLine();
        }
    }
}