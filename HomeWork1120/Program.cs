using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1120
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Task1
			Circle circle = new Circle(6);
			Rectangle rectangle = new Rectangle(4, 8);
			Console.WriteLine("Dairenin sahesi: " + circle.Area());
			Console.WriteLine("Duzbucaqlinin sahesi:" + rectangle.Area());
			#endregion

			#region Task 2

			#endregion

		}
	}
	#region Task1
	abstract class Shape
	{
		public abstract double Area();
	}
	class Circle : Shape

	{
		private double radius;
		public  Circle(double _radius)
		{
			radius = _radius;
		}
		public override double Area()
		{
			return 3.14 * radius * radius;
		}
	}
	class Rectangle : Shape
	{
		private double widht;
		private double heigth;
		public Rectangle(double _widht, double _heigth)
		{
			widht = _widht;
			heigth = _heigth;
		}
		public override double Area()

		{
			return widht * heigth;
		}


	}
	#endregion
	#region Task 2

	#endregion
}
