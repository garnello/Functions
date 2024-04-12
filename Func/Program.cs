namespace Practical_git;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 6, 9, 12, 15 };

        double average = Average(numbers);
        Console.WriteLine("Среднее значение: " + average);
        
        int a = 5;
        int b = 3;
        
        int add = Addition(a, b);
        Console.WriteLine("Равно: " + add);

        int numberToCheck = 7;
        bool isEven = CheckIfEven(numberToCheck);
        Console.WriteLine(numberToCheck + " четное? " + isEven);
        
        double area = Square(3, 5);
        Console.WriteLine("Площадь прямоугольника: " + area);
    }

    static double Average(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }
    
    public static int Addition(int a, int b)
    {
        return a + b;
    }

    static bool CheckIfEven(int number)
    {
        return number % 2 == 0;
    }
    
    static double Square(double length, double width)
    {
        return length * width;
    } 


}