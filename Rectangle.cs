using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterTower {
	internal class Rectangle : Tower
	{
		public Rectangle() {
			Print();
        }

		private void Print() {
			if ((Height == Width) || (Math.Abs(Width - Height) > 5))
                Console.WriteLine("Tower area is: {0}", Width * Height);
			else
                Console.WriteLine("Tower perimeter is: {0}", Width * 2 + Height * 2);
		}
	}
}
