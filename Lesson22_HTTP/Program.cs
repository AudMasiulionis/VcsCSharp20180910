#pragma warning disable

namespace Lesson22_HTTP
{
    class Program
    {
        public static void Main()
        {
            var client = new CoursesClient();
            var a = client.GetProduct(1);
        }
    }
}
