
using System;

namespace OOP_Assignment
{
    
    // Problem 1 + Problem 4 + Problem 5
    // Point Struct - Constructors, Constructor Overloading,
    // and ToString()
    

    struct Point
    {
        public int X;
        public int Y;

        // Constructor with one parameter
        public Point(int x)
        {
            X = x;
            Y = 0;
        }

        // Constructor with two parameters
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}";
        }
    }


    
    // Problem 2
    // Access Modifiers
    
    class TypeA
    {
        private int F = 10;
        internal int G = 20;
        public int H = 30;

        public void ShowInsideClass()
        {
            Console.WriteLine($"Private F = {F}");
            Console.WriteLine($"Internal G = {G}");
            Console.WriteLine($"Public H = {H}");
        }
    }


   
    // Problem 3
    // Employee Struct - Encapsulation

    struct Employee
    {
        private int EmpId;
        private string Name;
        private double Salary;

        // Method to get Name
        public string GetName()
        {
            return Name;
        }

        // Method to set Name
        public void SetName(string name)
        {
            Name = name;
        }

        // Property for EmpId
        public int EmployeeId
        {
            get
            {
                return EmpId;
            }
            set
            {
                EmpId = value;
            }
        }

        // Property for Salary
        public double EmployeeSalary
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }
    }


    
    // Problem 6
    // Struct vs Class
    // Value Type vs Reference Type
   
    struct PointValue
    {
        public int X;

        public PointValue(int x)
        {
            X = x;
        }
    }

    class EmployeeReference
    {
        public string Name;

        public EmployeeReference(string name)
        {
            Name = name;
        }
    }


    
    // Part 2
    // Copy Constructor
    
    class EmployeeCopy
    {
        public string Name;
        public double Salary;

        // Normal Constructor
        public EmployeeCopy(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        // Copy Constructor
        public EmployeeCopy(EmployeeCopy employee)
        {
            Name = employee.Name;
            Salary = employee.Salary;
        }
    }


    
    // Part 2
    // Indexer
    
    class StudentCollection
    {
        private string[] students = new string[3];

        // Indexer
        public string this[int index]
        {
            get
            {
                return students[index];
            }

            set
            {
                students[index] = value;
            }
        }
    }


   
    // Main Program
    
    
class Program
    {
        static void Main()
        {
            // 1. Point Struct
            
            Console.WriteLine("Point Struct ");

            Point p1 = new Point(10, 20);

            Console.WriteLine(p1);


            
            // 2. Access Modifiers
            

            Console.WriteLine("\n Access Modifiers ");

            TypeA obj = new TypeA();

            // Private F cannot be accessed here
            // Console.WriteLine(obj.F);

            // Internal G can be accessed inside the same project
            Console.WriteLine($"Internal G = {obj.G}");

            // Public H can be accessed from anywhere
            Console.WriteLine($"Public H = {obj.H}");

            // Accessing all members from inside the class
            obj.ShowInsideClass();


            
            // 3. Encapsulation
            

            Console.WriteLine("\n Encapsulation ");

            Employee emp = new Employee();

            emp.EmployeeId = 101;
            emp.SetName("Haneen");
            emp.EmployeeSalary = 15000;

            Console.WriteLine($"Employee ID: {emp.EmployeeId}");
            Console.WriteLine($"Name: {emp.GetName()}");
            Console.WriteLine($"Salary: {emp.EmployeeSalary}");


            
            // 4. Constructor Overloading
           

            Console.WriteLine("\nConstructor Overloading ");

            Point p2 = new Point(50);
            Point p3 = new Point(50, 100);

            Console.WriteLine($"Point 1: {p2}");
            Console.WriteLine($"Point 2: {p3}");


            
            // 5. Custom ToString()
            

            Console.WriteLine("\n Custom ToString() ");

            Point p4 = new Point(10, 20);
            Point p5 = new Point(30, 40);
            Point p6 = new Point(50, 60);

            Console.WriteLine(p4);
            Console.WriteLine(p5);
            Console.WriteLine(p6);


            
            // 6. Struct vs Class
            

            Console.WriteLine("\n Struct vs Class ");

            PointValue point = new PointValue(10);

            Console.WriteLine($"Point before method: {point.X}");

            ChangePoint(point);

            Console.WriteLine($"Point after method: {point.X}");


            EmployeeReference employee =
            new EmployeeReference("Haneen");

            Console.WriteLine($"Employee before method: {employee.Name}");

            ChangeEmployee(employee);

            Console.WriteLine($"Employee after method: {employee.Name}");


            
            // 7. Copy Constructor
            

            Console.WriteLine("\n Copy Constructor ");

            EmployeeCopy employee1 =
            new EmployeeCopy("Haneen", 15000);

            EmployeeCopy employee2 =
            new EmployeeCopy(employee1);

            Console.WriteLine("Employee 1:");
            Console.WriteLine($"Name: {employee1.Name}");
            Console.WriteLine($"Salary: {employee1.Salary}");

            Console.WriteLine("\nEmployee 2 (Copied):");
            Console.WriteLine($"Name: {employee2.Name}");
            Console.WriteLine($"Salary: {employee2.Salary}");

            

// 8. Indexer

Console.WriteLine("\n Indexer ");

            StudentCollection students =
            new StudentCollection();

            students[0] = "Haneen";
            students[1] = "Ahmed";
            students[2] = "Mona";

            Console.WriteLine($"Student 0: {students[0]}");
            Console.WriteLine($"Student 1: {students[1]}");
            Console.WriteLine($"Student 2: {students[2]}");


            
            // End
            

            Console.WriteLine("\n Program Finished ");
        }


       
        // Method for Struct
       

        static void ChangePoint(PointValue point)
        {
            point.X = 100;
        }


       
        // Method for Class
       
        static void ChangeEmployee(EmployeeReference employee)
        {
            employee.Name = "Ahmed";
        }
    }
}