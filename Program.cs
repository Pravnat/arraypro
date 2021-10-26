using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pancard
{
    class Program {
		public static void getDetails()
		{
			Console.WriteLine("How many PAN Number do you want to Enter?:");
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				int[,] arr;
				Console.WriteLine("Please Enter the employee" + "name");
				string name = Console.ReadLine();
				Console.WriteLine("Enter how many accounts do you have:");
				int accno = Convert.ToInt32(Console.ReadLine());
				int accbal = accno;
				arr = new int[accno, accbal];
				Console.WriteLine("Enter your accountNo and Account Balance");
				for (int j = 0; j < accno; j++)
				{
					for (int k = 0; k < accbal; k++)
					{

						arr[j, k] = Convert.ToInt32(Console.ReadLine());
					}
				}

				Console.WriteLine("Your AccountNo and Available Account balance:");
				for (int j = 0; j < accno; j++)
				{
					for (int k = 0; k < accbal; k++)
					{
						Console.Write(arr[j, k] + " ");
					}
					Console.WriteLine();
				}

			}
			Console.Read();
		}


		static void Main(string[] args)
        {

			getDetails();
            
        }
    }
}
