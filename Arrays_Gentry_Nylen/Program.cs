namespace Arrays_Gentry_Nylen
{
    internal class Program
    {
        static void Main()
        {
            int n, sum = 0;

            // Ask user for the number of elements
            Console.Write("Enter the number of elements in the array: ");
            n = int.Parse(Console.ReadLine());

            // Declare the array with the user-defined size
            int[] arr = new int[n];

            // Ask user to input values for all the array elements
            Console.WriteLine("Enter {0} integers: ", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];  // Adding the current element to sum
            }

            // Print the sum of all elements
            Console.WriteLine("The sum of all elements in the array is: " + sum);

            // Sorting the array in ascending order using Array.Sort
            Array.Sort(arr);

            // Print the sorted array
            Console.WriteLine("The sorted array in ascending order is: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
