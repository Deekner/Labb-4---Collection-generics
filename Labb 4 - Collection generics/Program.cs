using System;
using System.Collections.Generic;

namespace Labb_4___Collection_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee()
            {
                id = 1001,
                name = "Dennis",
                gender = "Male",
                salary = 45000
            };
          

            Employee E2 = new Employee()
            {
                id = 1002,
                name = "John",
                gender = "Male",
                salary = 40000
            };


            Employee E3 = new Employee()
            {
                id = 1003,
                name = "Thomas",
                gender = "Male",
                salary = 55000
            };

            Employee E4 = new Employee()
            {
                id = 1004,
                name = "Vivien",
                gender = "Female",
                salary = 42000
            };

            Employee E5 = new Employee()
            {
                id = 1005,
                name = "Frida",
                gender = "Female",
                salary = 38000
            };


            //Adds objects to my stack
            Stack<Employee> Stack = new Stack<Employee>();

            Stack.Push(E1);
            Stack.Push(E2);
            Stack.Push(E3);
            Stack.Push(E4);
            Stack.Push(E5);


            //Prints out all my objects in a stack
            foreach (Employee item in Stack)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary {3}", item.id, item.name, item.gender, item.salary);
                Console.WriteLine("Items left in the stack = {0}", Stack.Count);
            }

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Retrieve using pop metod");

            //Decrement items in my stacks
            while (Stack.Count > 0)
            {
                Stack.Pop();
                Console.WriteLine("Items left in the stack = {0}", Stack.Count);
            }

            //Restocks the items
            Stack.Push(E1);
            Stack.Push(E2);
            Stack.Push(E3);
            Stack.Push(E4);
            Stack.Push(E5);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Retrieve using peek metod");

            Employee Employee1 = Stack.Peek();
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary {3}", Employee1.id, Employee1.name, Employee1.gender, Employee1.salary);
            Console.WriteLine("Items left in the stack = {0}", Stack.Count);
            Stack.Pop();
            Employee Employee2 = Stack.Peek();
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary {3}", Employee2.id, Employee2.name, Employee2.gender, Employee2.salary);
            Console.WriteLine("Items left in the stack = {0}", Stack.Count);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Checks if Employee Nr3 is in stack\n");
            //Checks if Employee Nr3 is in stack
            if (Stack.Contains(E3))
            {
                Console.WriteLine("The Item is in stack");
            }
            else
            {
                Console.WriteLine("Item is not in Q");
            }

            
            Console.WriteLine("\n<<<<<<<<<<<<<<<<Part 2 List>>>>>>>>>>>>>>>>>>>>>>\n");

            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(E1);
            listEmployee.Add(E2);
            listEmployee.Add(E3);
            listEmployee.Add(E4);
            listEmployee.Add(E5);

            //Does the list contain Employee 3?
            if (listEmployee.Contains(E3))
            {
                Console.WriteLine("Employee 3 object does exist in the list ");
            }
            else
            {
                Console.WriteLine("Employee 3 object does not exist in the list ");
            }

            //Finds the first Make in list
            Employee FindFirstGenderMale = listEmployee.Find(s => s.gender == "Male");
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", FindFirstGenderMale.id, FindFirstGenderMale.name, FindFirstGenderMale.gender, FindFirstGenderMale.salary);


            //Finds all males in employee
            Console.WriteLine("\n-------------------------------------------------------\n");
            List<Employee> FindAllMale = listEmployee.FindAll(s => s.gender == "Male");

            foreach (Employee item in FindAllMale)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", item.id, item.name, item.gender, item.salary);
            }
        }
    }
}
