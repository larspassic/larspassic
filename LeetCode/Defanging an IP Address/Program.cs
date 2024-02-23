namespace Defanging_an_IP_Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string inputIP = "127.0.0.1";

            string result = DefangIPaddr(inputIP);

            Console.WriteLine(result);
        }

        public static string DefangIPaddr(string address)
        {
            string defangedAddress = null;

            defangedAddress = address.Replace(".", "[.]");

            return defangedAddress;
        }
    }
}
