using Tap.Mocking.Repository;

namespace Tap.Mocking.Domain
{
    public class StudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public IReadOnlyCollection<Student> GetStudents()
        {
            return this.studentRepository.GetAll();
        }

        public IReadOnlyCollection<Student> GetStudentsInFinalYear()
        {
            return this.studentRepository.GetAll().Where(student => student.CurrentStudyYear == 3).ToList();
        }
    }
}
