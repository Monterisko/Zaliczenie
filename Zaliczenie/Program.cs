namespace Zaliczenie;

public class Program
{
    static double averageArray(int[] A)
    {
        double avarage = 0.0;
        for (int i = 0; i < 11; i++)
        {
            avarage += A[i];
        }

        return avarage / 11;
    }

    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    
    public static void Main(string[] args)
    {
        int[] arithmetic = new int[11];
        int[] geometric = new int[11];
        int[] sumArrays = new int[11];
        int[] reversSumArrays = new int[11];
        Console.Write("Wprowadź liczbę:");
        bool tryParse = int.TryParse(Console.ReadLine(), out int userInput);
        while (!tryParse)
        {
            Console.WriteLine("Niepoprawna wartość!");
            Console.Write("Wprowadź liczbę:");
            tryParse = int.TryParse(Console.ReadLine(), out userInput);
        }
        while ( userInput != 0)
        {
            Console.WriteLine("Pobrano liczbę");
            arithmetic[0] = 0;
            geometric[0] = userInput;
            for (int i = 1; i < 11; i++)
            {
                arithmetic[i] = arithmetic[i - 1] + userInput;
                geometric[i] = geometric[i - 1] * (-2);
            }

            for (int i = 0; i < 11; i++)
            {
                sumArrays[i] = arithmetic[i] + geometric[i];
            }

            int j = 10;
            for (int i = 0; i < 11; i++)
            {
                reversSumArrays[j] = sumArrays[i];
                j -= 1;
            }
            foreach (var VARIABLE in arithmetic)
            {
                Console.Write(VARIABLE + " ");   
            }
            Console.WriteLine();
            foreach (var VARIABLE in geometric)
            {
                Console.Write(VARIABLE + " ");   
            }
            Console.WriteLine();
            foreach (var VARIABLE in sumArrays)
            {
                Console.Write(VARIABLE + " ");   
            }
            Console.WriteLine();
            foreach (var VARIABLE in reversSumArrays)
            {
                Console.Write(VARIABLE + " ");   
            }
            Console.WriteLine();
            Console.WriteLine($"Średnia w pierwszej tablicy: {averageArray(arithmetic)}");
            Console.WriteLine($"Średnia w drugiej tablicy: {averageArray(geometric)}");
            Console.WriteLine($"Średnia w trzeciej tablicy: {averageArray(sumArrays)}");
            Console.WriteLine($"Średnia w czwartej tablicy: {averageArray(reversSumArrays)}");
            if (userInput > 0)
            {
                Console.WriteLine($"{userInput}-ty wyraz Fibonacciego to: {Fibonacci(userInput)}");
            }
            Console.Write("Wprowadź liczbę:");
            tryParse = int.TryParse(Console.ReadLine(), out userInput);
            while (!tryParse)
            {
                Console.WriteLine("Niepoprawna wartość!");
                Console.Write("Wprowadź liczbę:");
                tryParse = int.TryParse(Console.ReadLine(), out userInput);
            }
        }
        
        Console.WriteLine($"{userInput}-wy wyraz Fibonacciego to:{Fibonacci(userInput)}");
        Console.WriteLine("Koniec programu");
    }
}