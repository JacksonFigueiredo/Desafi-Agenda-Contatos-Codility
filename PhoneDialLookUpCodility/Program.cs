using System.Collections.Generic;
using System.Linq;

namespace PhoneDialLookUpCodility
{
    internal class Program
    {
        public static string Solution(string[] A, string[] B, string P)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            string contact = "";
            string result = "";

            for (int i = 0; i < A.Length; i++)
            {
                phoneBook.Add(A[i], B[i]);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].Length <= 0 || A[i].Length >= 10)
                {
                    phoneBook.Remove(A[i]);
                }

            }

            foreach (string phone in phoneBook.Values)
            {
                if (P.Length > 1)
                {
                    if (phone.Contains(P))
                    {
                        result = phone;
                    }
                }
                else
                {
                    return "No Contact";
                }

            }

            foreach (KeyValuePair<string, string> p in phoneBook)
            {
                if (p.Value.Contains(result))
                {
                    contact = p.Key;
                }
            }
            return contact;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(new String[] { "pim", "pom" }, new String[] { "9999999199", "777888999" }, "8899")); //pom
            Console.WriteLine(Solution(new String[] { "tom", "jerry" }, new String[] { "012345678", "777888999" }, "345")); //tom
            Console.WriteLine(Solution(new String[] { "ed", "frank" }, new String[] { "999999999", "777888999" }, "")); // No contact
            //  Console.WriteLine(Solution(new String[] { "eddie", "frank99" }, new String[] { "999999999", "777888999" }, "8899")); // No contact
            //  Console.WriteLine(Solution(new String[] { "jerry", "frank" }, new String[] { "999999999", "777888999" }, "8899")); // No contact
        }
    }
}



