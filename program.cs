using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolifics_Project_Manager
{
    class program
    {
        static void Main(string[] args)
        {
			int[] age = new int[6];
			string[] name = new string[6];
			int[] id = new int[6];
			string[] mail = new string[6];
			long[] mobile = new long[6];
			string[] Address = new string[6];
			int[] RoleId = new int[6];
			int[] projectid = new int[6];
			string[] projectName = new string[6];
			string[] sdate = new string[6];
			string[] edate = new string[6];
			string[] roleName = new string[6];
			int i;
			Console.WriteLine("Enter number of Attempts:");
			int n = Convert.ToInt32(Console.ReadLine());

			while (n >= 1)

			{
				Console.WriteLine("1.Add Employee:");
				Console.WriteLine("2.Add Project");
				Console.WriteLine("3.Add Role");
				Console.WriteLine("4.View Employees");
				Console.WriteLine("5.View Projects");
				Console.WriteLine("6.View Roles");
				Console.WriteLine("7.Quit");
				Console.WriteLine("============ ");
				Console.WriteLine("Choose anyone Option:");

				int emp = Convert.ToInt32(Console.ReadLine());

				switch (emp)
				{
					case 1:
						for (i = 0; i < 1; i++)
						{
							Console.Write("Enter your name:");
							name[i] = Console.ReadLine();
							Console.Write("Enter your age:");
							age[i] = Convert.ToInt32(Console.ReadLine());
							Console.Write("Enter your Id:");
							id[i] = Convert.ToInt32(Console.ReadLine());
							Console.Write("Enter your email id:");
							mail[i] = Console.ReadLine();
							Console.Write("Enter your Mobile number:");
							mobile[i] = Convert.ToInt64(Console.ReadLine());
							Console.Write("Enter your Address:");
							Address[i] = Console.ReadLine();
							Console.Write("Enter your RoleID:");
							RoleId[i] = Convert.ToInt32(Console.ReadLine());

						}

						goto default;
						break;
					case 2:
						for (i = 0; i < 1; i++)
						{
							Console.Write("Enter your Project name:");
							projectName[i] = Console.ReadLine();
							Console.Write("Enter your Project Id:");
							projectid[i] = Convert.ToInt32(Console.ReadLine());
							Console.Write("Enter your Project Startdate:");
							sdate[i] = Console.ReadLine();
							Console.Write("Enter your Project Enddate:");
							edate[i] = Console.ReadLine();

						}

						goto default;
						break;
					case 3:
						for (i = 0; i < 1; i++)
						{
							Console.Write("Enter your Role:");
							roleName[i] = Console.ReadLine();
							Console.Write("Enter your Role Id:");
							RoleId[i] = Convert.ToInt32(Console.ReadLine());
						}
						goto default;
						break;
					case 4:
						for (i = 0; i < 1; i++)
						{
							Console.WriteLine("========");
							Console.WriteLine("Employee Details");
							Console.WriteLine("Name:{0}", name[i]);
							Console.WriteLine("Age:{0}", age[i]);
							Console.WriteLine("Id:{0}", id[i]);
							Console.WriteLine("Email:{0}", mail[i]);
							Console.WriteLine("Mobile:{0}", mobile[i]);
							Console.WriteLine("Address;{0}", Address[i]);
							Console.WriteLine("RoleId:{0}", RoleId[i]);
							Console.WriteLine("=========== ");
						}

						break;

					case 5:
						for (i = 0; i < 1; i++)
						{
							Console.WriteLine("========");
							Console.WriteLine("Project Details");
							Console.WriteLine("Project Name:{0}", projectName[i]);
							Console.WriteLine("Project Id:{0}", projectid[i]);
							Console.WriteLine("Start Date:{0}", sdate[i]);
							Console.WriteLine("End Date:{0}", edate[i]);
							Console.WriteLine("========");
						}

						break;

					case 6:
						for (i = 0; i < 1; i++)
						{
							Console.WriteLine("========");
							Console.WriteLine("Role Details");
							Console.WriteLine("Role Name:{0}", roleName[i]);
							Console.WriteLine("RoleId:{0}", RoleId[i]);
							Console.WriteLine("========");
						}

						break;
					case 7:
						Console.WriteLine("Press any key to exit");
						break;
					default:
						Console.WriteLine("Successfully Entered details");
						break;


				}
				n--;

			}
			Console.ReadLine();


		}

	}
}
