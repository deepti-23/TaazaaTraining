using System.ComponentModel.DataAnnotations;
namespace StudentRepository.Models
{
    public class StudentsInfo
    {
        public int StudentId{get;set;}
        public string StudentName{get;set;}

        RangeAttribute[20,40];
        public int StudentAge{get;set;}
        public string StudentEmail{get;set;}
    }
}