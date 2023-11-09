using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_w_Mongo.Applicaiton;

namespace API_w_Mongo.Application.Interfaces
{
    public class StudentStoreDatabaseSettings : IStudentStoreDatabaseSettings
    {

        public string StudentCoursesCollectionName { get; set; } = "apicollection";


        public string ConnectionString { get; set; } = "mongodb+srv://enis:RWPBpD7NZ6KCNmgk@apitest.6mfasrb.mongodb.net/";
        
        public string DatabaseName { get; set; } = "apitest";


    }
}
