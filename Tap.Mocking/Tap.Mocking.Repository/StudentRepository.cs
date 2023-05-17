using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Mocking.Repository
{
    internal class StudentRepository : IStudentRepository
    {
        public void Add(Student student)
        {
            //add student
        }

        public IReadOnlyCollection<Student> GetAll()
        {
            //get all students from database
            return new List<Student>();
        }
    }
}
