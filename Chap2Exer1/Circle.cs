using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2Exer1
{
	public class Circle
	{

		public double Radius { get; set; }
		public double Circumference { get; set; }
		
		public double Area { get; set; }

		public double Diameter { get; set; }


		public Circle(double aRadius) {
		
			Radius = aRadius;
			Circumference = 2 * Math.PI * Radius;
			Area = Math.PI * Math.Pow(Radius, 2);
			Diameter = 2 * Radius;

		}

	}
}
