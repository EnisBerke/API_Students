using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_w_Mongo.Applicaiton.Interfaces
{
    internal class StudentStoreDatabaseSettings : IStudentStoreDatabaseSettings
    {

        string CollectionName { get; set; } = String.Empty;
        string IStudentStoreDatabaseSettings.CollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ConnectionString { get; set; } = String.Empty;
        string IStudentStoreDatabaseSettings.ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string DatabaseName { get; set; } = String.Empty;
        string IStudentStoreDatabaseSettings.DatabaseName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
