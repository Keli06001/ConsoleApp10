using System;
namespace inlämning_felhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett heltal");
            string input=Console.ReadLine();
            int result;
            if (EgenTryParse(input, out result))
            {
                Console.WriteLine("Konverteringen lyckades: "+ result);
            }
            else
            {
                Console.WriteLine("Du angav något annat än ett heltal. (Avrättning)");
            }

        }
        public static bool EgenTryParse(string input, out int result)
        {
            result = 0;

           for(int i= 0; i<input.Length; i++)
            {
                if (input[i] <  '0' || input[i] >'9')
                {
                    return false;
                }
                result = result + input[i];
            }
           return true;
        }
    }
}
