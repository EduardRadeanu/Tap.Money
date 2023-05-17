namespace Tap.Mocking.Repository
{
    public interface IStudentRepository
    {
        IReadOnlyCollection<Student> GetAll();

        void Add(Student person);
    }
}
