using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo();

        }

        public void Login(string userName, string password)
        {
            const string currentUserName = "admin";
            const string currentPassword = "admin";

            if (userName != currentUserName || password != currentPassword) )
            {
                throw new InvalidPasswordException("Wrong credentials");
            }
        }

        public static double factorial_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial_Recursion(number - 1);
        }

        private static int Foo()
        {
            try
            {
                Console.WriteLine("Ivesk skaiciu");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bloga ivestis");
                return Foo();
            }
        }

        //    static void Main(string[] args)
        //    {
        //        try
        //        {
        //            Convert.ToByte(Console.ReadLine());
        //            Console.WriteLine("1");

        //            Example.Foo(2);

        //            Example.Bar(null);
        //        }
        //        catch (FormatException ex)
        //        {
        //            Console.WriteLine("Blogas skaiciaus formatas");
        //        }
        //        catch (Klaida ex)
        //        {

        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Kita klaida. {ex.Message}");
        //            //irasyti i loga(ex)
        //        }
        //        finally
        //        {
        //            Console.WriteLine("finally");
        //        }
        //    }
        //}
    }
}
