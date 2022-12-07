using Api.brive.DataAccess;
using Api.Brive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brive.Api.BusinessLogic.Students
{
    public  class StudentsBL
    {


        public async  Task<List<Student>> GetStudents()
        {
            return await App.DataAccess.GetStudents();

        }
    }
}
