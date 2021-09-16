using System.Collections.Generic;
using StudentRepository.Models;
using System.Linq;

namespace StudentRepository.Repository
{
    public class StudentsRepo : IStudentsRepo
    {
        List<StudentsInfo> LStudent=new List<StudentsInfo>();
        void IStudentsRepo.Add(StudentsInfo studentsInfo)
        {
            LStudent.Add(studentsInfo);
        }

        void IStudentsRepo.Delete(int id)
        {
            var SearchRecord=LStudent.Where(ctr=>ctr.StudentId==id).FirstOrDefault();
            if (SearchRecord!=null)
            {
                LStudent.Remove(SearchRecord);
            }
        }

        IEnumerable<StudentsInfo> IStudentsRepo.GetAll()
        {
            return LStudent;
        }

        StudentsInfo IStudentsRepo.Search(int id)
        {
            var SearchRecord=LStudent.Where(ctr=>ctr.StudentId==id).FirstOrDefault();
            return SearchRecord;
        }

        void IStudentsRepo.Update(StudentsInfo studentsInfo)
        {
            var SearchRecord=LStudent.Where(ctr=>ctr.StudentId==studentsInfo.StudentId).FirstOrDefault();
            if (SearchRecord!=null)
            {
                SearchRecord.StudentName=studentsInfo.StudentName;
                SearchRecord.StudentEmail=studentsInfo.StudentEmail;
                SearchRecord.StudentAge=studentsInfo.StudentAge;
            }
        }
    }
}