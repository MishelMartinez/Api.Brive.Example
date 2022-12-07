using Api.Brive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.brive.DataAccess.DataAccess.SqlServer
{
    public class SqlServerDataAccess : IDataAccess
    {
        public Task<Student> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentByName(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Task<List<Teacher>> GetTeachers()
        {
            throw new NotImplementedException();
        }
    }
}
