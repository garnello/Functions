namespace Practical_git;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 6, 9, 12, 15 };

        int a = 5;
        int b = 3;
        
        double average = Average(numbers);
        Console.WriteLine("Среднее значение: " + average);
        
        int add = Addition(a, b);
        Console.WriteLine("Равно: " + add);

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


}