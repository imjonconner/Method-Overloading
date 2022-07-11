namespace Method_Overloading
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            if (isTrue)
            {
                sum = num1 + num2;
                if (sum )
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}