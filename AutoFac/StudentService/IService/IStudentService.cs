using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFac.StudentService.IService
{
    public interface IStudentService
    {
        string GetName(long id);
    }
}
