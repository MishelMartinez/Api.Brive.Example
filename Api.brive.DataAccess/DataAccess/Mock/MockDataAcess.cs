using Api.Brive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.brive.DataAccess.DataAccess.Mock
{
    public class MockDataAcess : IDataAccess
    {
        public Task<Student> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentByName(string Name)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetStudents()
        {
           
            List<Student> students = new List<Student>();

            students.Add(new Student()
            {
                Id = 1,
                Name= "Luiggy",
                LastName= "Carlin",
                Age= 27,
                Address= "Peru av.lopez 244",
                Semester= 6,
                ListSubjects = new List<Subject>()
                {
                    new Subject()
                    {
                        Id=1,
                        Name= "POO",
                        Credits = 16
                    },
                    new Subject()
                    {
                        Id = 2,
                        Name= "Programacion Web",
                        Credits= 10
                    }

                }
                
            });


            students.Add(new Student()
            {
                Id = 2,
                Name = "Antonio",
                LastName = "Martinez",
                Age = 25,
                Address = "Mexico av.don  244",
                Semester = 4,
                ListSubjects = new List<Subject>()
                {
                    new Subject()
                    {
                        Id=1,
                        Name= "POO",
                        Credits = 16
                    },
                    new Subject()
                    {
                        Id = 2,
                        Name= "Programacion Web",
                        Credits= 10
                    }

                }

            });

            students.Add(new Student()
            {
                Id = 3,
                Name = "Luisa",
                LastName = "Peralta",
                Age = 26,
                Address = "Mexico av.don  244",
                Semester = 5,
                ListSubjects = new List<Subject>()
                {
                    new Subject()
                    {
                        Id=5,
                        Name= "Base de datos",
                        Credits = 14
                    },
                    new Subject()
                    {
                        Id = 2,
                        Name= "Programacion Web",
                        Credits= 10
                    }

                }

            });


            return students;



        }

        public Task<List<Teacher>> GetTeachers()
        {
            throw new NotImplementedException();
        }
    }
}
