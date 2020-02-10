using Autofac;
using AutoFac.Infrastructure.IOC;
using AutoFac.StudentService.IService;
using System;

namespace AutoFac.ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Container.Init();
            PrintStudentName(10001);

            Console.ReadKey();
        }

        private static void PrintStudentName(int id)
        {
            IStudentService studentService = Container.Instance.Resolve<IStudentService>();
            string name = studentService.GetName(id);
            Console.WriteLine("Hello {0}", name);
        }
    }

    
}
