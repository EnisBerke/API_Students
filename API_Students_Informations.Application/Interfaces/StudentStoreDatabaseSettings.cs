using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Students_Informations.Applicaiton;

namespace API_Students_Informations.Application.Interfaces
{
    public class StudentStoreDatabaseSettings : IStudentStoreDatabaseSettings
    {

        public string StudentCoursesCollectionName { get; set; } = "apicollection";


        public string ConnectionString { get; set; } = "mongodb+srv://enis:o9lsKMIbaqdLzPIh@apitest.6mfasrb.mongodb.net/";
        
        public string DatabaseName { get; set; } = "apitest";


    }
}
