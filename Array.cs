using System;

namespace ProlificsProjectManage
{
    static class Program
    {

        static void Main(string[] args)
        {
            string[] project = new string[50];
            string[] emp = new string[50];
            string[] role = new string[50];
            int Project1 = 0;
            int Emp1 = 0;
            int Role1 = 0;
            int i;

            void Project_add()   
            {
                Console.Write("Number of Projects you want to Add: ");
                int Project = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine("Project name: ");
                for (i = 1; i <= Project; i++)
                {
                    project[Project1++] = Console.ReadLine();
                }
                Console.WriteLine("Successfully Added");
            }
            void Project_view()  
            {
                //Console.Write("Added projects are: ");
                for (i = 0; i <= Project1; i++)
                {
                    Console.WriteLine("name is " +  project[i]);
        }
    }
    void add_Employee()  
    {
        Console.Write("Employees you want to Add: ");
        int Emp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name of Employee: ");
        for (i = 1; i <= Emp; i++)
        {
            emp[Emp1++] = Console.ReadLine();
        }
        Console.WriteLine("Employee Added Successfully");
    }
    void Employee_view() 
    {
        Console.Write("Added Employees are: ");
        for (i = 0; i <= Emp1; i++)
        {
            Console.WriteLine(emp[i]);
        }
    }
    void Role_add()  
    {
        Console.Write("Number of Role you want to add: ");
        int Role = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name of Roles: ");
        for (i = 1; i <= Role; i++)
        {
            role[Role1++] = Console.ReadLine();
        }
        Console.WriteLine("Roles Added Successfully");
    }
    void Role_view()     
    {
        Console.Write("Added Roles are: ");
        for (i = 0; i <= Role1; i++)
        {
            Console.WriteLine(role[i]);
        }
    }
            while (true)
            {
                Console.WriteLine(" 1) Add Project ");
                Console.WriteLine(" 2) View Project ");
                Console.WriteLine(" 3) Add Employee");
                Console.WriteLine(" 4) view Employee");
                Console.WriteLine(" 5) Add Role");
                Console.WriteLine(" 6) View Role");
                Console.WriteLine(" 7) Exit");
                Console.Write("Select any one option: ");

                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Project_add();
                        break;
                    case 2:
                        Project_view();
                        break;
                    case 3:
                        add_Employee();
                        break;
                    case 4:
                        Employee_view();
                        break;
                    case 5:
                        Role_add();
                        break;
                    case 6:
                        Role_view();
                        break;
                    case 7:
                        return;
                }
            }
          

        }
    }
}
