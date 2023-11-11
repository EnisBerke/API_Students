using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Students_Informations.Applicaiton
{
    public interface IStudentStoreDatabaseSettings
    {
        string StudentCoursesCollectionName { get; set; } 

        string ConnectionString { get; set; }

        string DatabaseName { get; set; }   
    }
}
