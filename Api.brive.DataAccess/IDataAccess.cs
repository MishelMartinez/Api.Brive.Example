using Api.Brive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.brive.DataAccess
{
    public interface IDataAccess
    {

        Task<List<Student>> GetStudents();


        Task<Student> GetStudentById(int id);

        Task<Student> GetStudentByName(string Name);

        Task<List<Teacher>> GetTeachers();
    }
}
