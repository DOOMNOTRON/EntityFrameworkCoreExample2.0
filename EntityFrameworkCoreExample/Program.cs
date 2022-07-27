using EntityFrameworkCoreExample;
using static EntityFrameworkCoreExample.EntityFrameworkCoreExample;

using StudentContext dbContext = new();

// Add with EF Core
Student s = new()
{
    FullName = "Doomnotron",
    EmailAddress = "DOOMNOTRON@doomnotronStudios.com",
    DateOfBirth = new DateTime(2000, 1, 1),
    Age = 22
    
};

Student s2 = new()
{
    FullName = "Verlehn",
    EmailAddress = "VERLEHN@doomnotronStudios.com",
    DateOfBirth = new DateTime(2000, 1, 1),
    Age = 22

};


dbContext.Students.Add(s); // Prepares the student insert statement
dbContext.SaveChanges(); // Executes pending insert. (In actuality: Execute any pending insert/update/delete)

dbContext.Students.Add(s2); // Prepares the student insert statement
dbContext.SaveChanges(); // Executes pending insert. (In actuality: Execute any pending insert/update/delete)

// Retrieve Students from DB. Select Query
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax

foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of { stu.EmailAddress}.");
    Console.WriteLine();
}

