using API_Students_Informations.Domain;
using API_Students_Informations.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Students_Informations.Applicaiton.Services
{
    public interface IStudentServices
    {
        List<Student> GetAll();
        Student Get(string id);
        List<Student> GetByList(List<string> student);
        Student Create(Student student);

        void Update(string id, Student student);

        void Remove(string id);
    }
}
