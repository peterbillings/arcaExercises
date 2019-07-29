using System;

namespace DatabaseConnectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //use this command in the console:
            // dotnet ef dbcontext scaffold "Server=LAPTOP-F2RUMMJU\SQLEXPRESS;Database=db01;Trusted_Connection=True;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -o DB01Model -c "db01"
        }
    }
}
