using StudentRepository.Models;
using System.Collections.Generic;
namespace StudentRepository.Repository
{
    public interface IStudentsRepo
    {
        void Add(StudentsInfo studentsInfo);
        public IEnumerable<StudentsInfo> GetAll();
        void Update(StudentsInfo studentsInfo);
        void Delete(int id);
        StudentsInfo Search(int id);

    }
}