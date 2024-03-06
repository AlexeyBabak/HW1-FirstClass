namespace HW1_FirstClass
{
    public static class StringExtensions
    {
        public static string GetValidatedAndCapitalizedInput(string prompt)
        {
            string input;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("The input cannot be empty. Please try again.");
                }
            }
            while (string.IsNullOrEmpty(input));

            return CapitalizeFirstLetter(input);
        }

        private static string CapitalizeFirstLetter(string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }
    }
}
