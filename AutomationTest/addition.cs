using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest
{
	internal class addition
	{
		
		public void AddNum()
		{
			Console.Write("Enter a n1:");
			int n1 = int.Parse(Console.ReadLine());
			Console.Write("Enter a n2:");
			int n2 = int.Parse(Console.ReadLine());
			Console.Write("Enter a n3:");
			int n3 = int.Parse(Console.ReadLine());
			int result = n1 + n2 + n3;
			Console.WriteLine(result);
		}

		public void Area()
		{
			Console.Write("Enter Length:");
			int len = int.Parse(Console.ReadLine());
			int area = len * len;
			Console.WriteLine(area);
		}


	}
}
