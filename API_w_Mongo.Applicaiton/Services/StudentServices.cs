using API_w_Mongo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using API_w_Mongo;

namespace API_w_Mongo.Applicaiton.Services
{
    internal class StudentServices : IStudentServices
    {
        private IMongoCollection<Student> _students;

        public StudentServices(IStudentStoreDatabaseSettings settings, IMongoClient mongoClient) 
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
           _students = database.GetCollection<Student>(settings.CollectionName);
            
        }
        public Student Create(Student student)
        {
            _students.InsertOne(student);
            return student;
        }

        public List<Student> Get()
        {
            return _students.Find(student => true).ToList();
        }

        public Student Get(string id)
        {
            return _students.Find(student => student.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _students.DeleteOne(student => student.Id == id);
        }

        public void Update(string id, Student student)
       {
            _students.ReplaceOne(student => student.Id == id, student);
        }
    }
}
