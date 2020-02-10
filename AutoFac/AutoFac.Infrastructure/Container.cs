using Autofac;
using AutoFac.Repository.IRepository;
using AutoFac.Repository.Repository;
using AutoFac.StudentService.IService;
using AutoFac.StudentService.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFac.Infrastructure.IOC
{
    public static class Container
    {
        public static IContainer Instance;

        public static void Init()
        {
            var builder = new ContainerBuilder();
            MyBuilder(builder);
            Instance = builder.Build();
        }

        private static void MyBuilder(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepositoryNew>().As<IStudentRepository>();
            builder.RegisterType<StudentSrv>().As<IStudentService>();

        }
    }

    
}
