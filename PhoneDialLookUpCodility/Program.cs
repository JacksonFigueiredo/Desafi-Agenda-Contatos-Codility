namespace PhoneDialLookUpCodility
{
    internal class Program
    {
        public string Solution(string[] A, string[] B, string P)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();      
            for (int i = 0; i < A.Length; i++)
            {
                phoneBook.Add(A[i], B[i]);
            }

            return "ss";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}