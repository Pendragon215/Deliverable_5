using System.Diagnostics.CodeAnalysis;

internal class Program
{
    static int[] random_array(int array_len)
    {
        Random random = new Random();
        int[] MyArray = new int[array_len];
        for (int i = 0; i < array_len; i++)
        {
            MyArray[i] = random.Next(10, 50);
        }
        return MyArray;
    }
    static int sum(int[] array)
    {
        int sum = 0;
        foreach (int i in array)
        {
            sum = sum + i;
        }
        return sum;
    }

    private static void Main(string[] args)
    {
        try
        {

            Console.Write("Enter an integer number between 5 and 15: ");


            int input = int.Parse(Console.ReadLine());
            int[] MyArray = random_array(input);
            Console.Write("The elements in the random array are: ");
            foreach (int i in MyArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("The sum is : " + sum(MyArray));
        }

        catch
        {
            Console.WriteLine("Please enter a number between 5 and 15");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }  
}

