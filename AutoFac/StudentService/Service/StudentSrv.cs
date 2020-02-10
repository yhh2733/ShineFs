using AutoFac.Repository.IRepository;
using AutoFac.StudentService.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFac.StudentService.Service
{
    public class StudentSrv : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentSrv(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public string GetName(long id)
        {
            var stu = _studentRepository.GetName(id);
            return stu;
        }
    }
}
