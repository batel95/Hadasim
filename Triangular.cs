using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TwitterTower {
	internal class Triangular : Tower 
	{
		public Triangular() {
			Choose();
		}

		private void Choose() {
			string ans;
			Console.WriteLine("Enter perimeter to calculate the triangular perimeter, Enter print to print the triangular.");
			do {
				ans = Console.ReadLine();
				ans = ans.ToLower();

				switch (ans) {
					case "perimeter":
						Perimeter();
						break;
					case "print":
						Print();
						break;

					default:
						Console.WriteLine("You have chosen a non -existing option");
						ans = "";
						break;
				}
			} while (ans == "");
		}

		private void Perimeter() {
			var per = 2 * Hypotenuse(Height, Width / 2) + Width;
            Console.WriteLine("Triangular perimeter is {0}.", per);
        }
		private void Print() {
			var iHeight = (int)Height;
			var iWidth = (int)Width;
			if (iHeight != Height || iWidth != Width || iWidth % 2 == 0 || Width > 2 * Height)
                Console.WriteLine("Cannot print the triangle");
			else
                TriangularStr();

        }

		private void TriangularStr() {
			var starArr = new int[(int)Height];
			var stars = (int)Width;
			var s = ((int)Height - 2)/((((int)Width - 1) / 2) - 1);
			string tempStr = "";
			int j = 0;
			starArr[0] = 1;
			starArr[starArr.Length - 1] = stars;
			stars -= 2;

			for (int i = starArr.Length - 2; i > 0; i--) {
				if (j == s) {
					if (stars != 3) {
						stars-=2;
						j = 0;
					}
				}
				starArr[i] = stars;
				j++;	
			}

			for (int i = 0; i < starArr.Length;  i++) {
				tempStr = "";
				for (int k = 0; k < starArr[i]; k++) {
					tempStr += "*";
				}
                Console.WriteLine(tempStr.PadLeft((((int)Width - starArr[i]) / 2 ) + starArr[i]));
			}

		}

		private Func<double, double, double> Hypotenuse = (legA, legB) 
			=> Math.Sqrt(Math.Pow(legA, 2) + Math.Pow(legB, 2));
	}


}

