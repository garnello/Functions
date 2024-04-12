namespace Practical_git;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 6, 9, 12, 15 };
        
        double average = Average(numbers);
        Console.WriteLine("Среднее значение: " + average);
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

}