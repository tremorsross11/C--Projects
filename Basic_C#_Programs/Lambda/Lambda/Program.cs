using System;
using System.Collections.Generic;


public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}


public class Program
{
    public static void Main()
    {
        List employees = new List()
        {
            new Employee { Id = 1, FirstName = "John", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
            new Employee { Id = 3, FirstName = "Joe", LastName = "Mills" },
            new Employee { Id = 4, FirstName = "Bob", LastName = "Jones" },
            new Employee { Id = 5, FirstName = "Roger", LastName = "Johnson" },
            new Employee { Id = 6, FirstName = "Sharon", LastName = "Jackson" },
            new Employee { Id = 7, FirstName = "Steve", LastName = "Williams" },
            new Employee { Id = 8, FirstName = "Joe", LastName = "Brown" },
            new Employee { Id = 9, FirstName = "Mary", LastName = "Thompson" },
            new Employee { Id = 10, FirstName = "Tim", LastName = "Davis" }
        };


        // Create a list of all employees with the first name “Joe”
        List<Employee> joes = new List<Employee>();
        foreach (Employee emp in employees)
        {
            if (emp.FirstName == "Joe")
            {
                joes.Add(emp);
            }
        }

        // Create a list of all employees with the first name “Joe” using a lambda expression
        List<Employee> joesLambda = employees.FindAll(emp => emp.FirstName == "Joe");

        // Create a list of all employees with an Id number greater than 5 using a lambda expression
        List<Employee> idsLambda = employees.FindAll(emp => emp.Id > 5);
