using System;

namespace ExamenFinal
{
    class Client2
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 7, 78, 9, 2, 24, 38, 78, 91, 96, 4, 6, 17, 101, 24, 38, 47, 37, 148, 2, 589 };
            bool HasDuplicates;
            foreach (ComplexityType complexityType in Enum.GetValues(typeof(ComplexityType)))
            {
                switch (complexityType)
                {
                    case ComplexityType.Lineal:
                        HasDuplicates = HasDuplicateValuesLineal(numbers);
                        Console.WriteLine(ComplexityType.Lineal.ToString() + " - HasDuplicates: " + HasDuplicates);
                        break;
                    case ComplexityType.Cuadratic:
                        HasDuplicates = HasDuplicateValuesCuadratic(numbers);
                        Console.WriteLine(ComplexityType.Cuadratic.ToString() + " - HasDuplicates: " + HasDuplicates);
                        break;
                    case ComplexityType.Exponential:
                        HasDuplicates = HasDuplicateValuesExponential(numbers);
                        Console.WriteLine(ComplexityType.Exponential.ToString() + " - HasDuplicates: " + HasDuplicates);
                        break;
                }
            }
            Console.ReadLine();
        }

        public static bool HasDuplicateValuesCuadratic(int[] numbers)
        {
            return true;
        }

        public static bool HasDuplicateValuesLineal(int[] numbers)
        {
            return true;
        }

        public static bool HasDuplicateValuesExponential(int[] numbers)
        {
            return true;
        }
    }
}
