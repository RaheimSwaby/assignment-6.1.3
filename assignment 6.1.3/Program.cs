namespace assignment_6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 3, 4, 5, 0 };
            int[] result = ZeroAtEnd(arr);
            Console.WriteLine($"array with zeros at the end ");
            Console.WriteLine(string.Join(", ", result));


        }


        public static int[] ZeroAtEnd(int[] arr)
        {
            if (arr.Length == 0)
                return arr;

           
            int index = 0; 

            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[index] = arr[i];
                    index++;
                }
            }

            
            while (index < arr.Length)
            {
                arr[index] = 0;
                index++;
            }

            return arr;
        }
    }
}
