using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            var service = new Sample();
            var sender = new EmailSender();
            service.SendEmail(sender);


            Console.WriteLine("Hello World!");
        }
    }
}
