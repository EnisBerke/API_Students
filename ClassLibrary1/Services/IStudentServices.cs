using API_w_Mongo.Domain;
using API_w_Mongo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_w_Mongo.Applicaiton.Services
{
    public interface IStudentServices
    {
        List<Student> Get();
        Student Get(string id);
        Student Create(Student student);

        void Update(string id, Student student);

        void Remove(string id);
    }
}
