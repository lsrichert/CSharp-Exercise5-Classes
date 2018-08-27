using System;
using System.Collections.Generic;

namespace exercise5Classes
{

    class Program
{
    public class Employee {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public int startDate { get; set; }
    }

    public class Company
{
    /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
public string companyName { get; set; }
public int dateCreated { get; set; }

// Create a public property for holding a list of current employees
public List<Employee> Employees = new List<Employee>();

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; set; }

        

        
    }
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
        Company bestCatSitters = new Company() {
            companyName = "Best Cat Sitters",
            dateCreated = new DateTime (2016, 1, 10)
        };
        // Create three employees
    Employee Stan = new Employee() {
        firstName = "Stan",
        lastName = "Stanley",
        title = "cat sitter"
         };

    Employee Molly = new Employee() {
        firstName = "Molly",
        lastName = "Molls",
        title = "owner"
    };

    Employee Jamie = new Employee() {
        firstName = "Jamie",
        lastName = "James",
        title = "cat walker"
    };
        // Assign the employees to the company
    bestCatSitters.Employees.Add(Stan);
    bestCatSitters.Employees.Add(Molly);
    bestCatSitters.Employees.Add(Jamie);
        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
    }
}




}
