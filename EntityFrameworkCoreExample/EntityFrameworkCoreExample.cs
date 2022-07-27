using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
    internal class EntityFrameworkCoreExample
    {
        // Entity Framwork Getting Started Guide
        // https://docs.microsoft.com/en-us/ef/core/get-started/overview/install

        // From the Visual Studio menu, select Tools > NuGet Package Manager > Package Manager Console

        // To install the SQL Server provider, run the following command in the Package Manager Console:
        // Install-Package Microsoft.EntityFrameworkCore.SqlServer

        public class StudentContext : DbContext
        {
            public StudentContext() // constructor
            {

            }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                // connection string: Server=(localdb)\\mssqllocaldb;Database="Insert_desired_name_here";Trusted_Connection=True;);
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
            }
        }
    }
}
