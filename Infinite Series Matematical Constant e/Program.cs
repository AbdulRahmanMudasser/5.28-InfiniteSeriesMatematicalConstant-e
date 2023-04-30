class MathematicalConstant
{
    static void Main(string[] args)
    {
        // declaring variables
        int number;  // number of series
        double e = 1.0;
        double factorial = 1.0;

        // taking user input
        Console.Write("Enter The Number Of Terms To Be Used In The Series:  ");
        number = Convert.ToInt32(Console.ReadLine());

        // calculating the estimated value of mathematical constant e
        for (int i = 1; i <= number; i++) 
        {
            // calculating factorial
            factorial = factorial * i;

            // calculating the value of e
            e = e + 1 / factorial;
        }

        // displaying qestimated value of e
        Console.WriteLine("Estimated Value Of e:  " + e);

        // displaying actual value of e
        Console.WriteLine("Actual Value Of e:  " + Math.E);
    }
    // end of main method
}
// end of class
