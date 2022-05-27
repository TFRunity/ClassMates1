using ClassMates.Models;

namespace ClassMates.InterFaces
{
    public interface IAllPerson
    {
        public IEnumerable<Student> ReturnObj { get; }
    }
}
