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
            /*Circle circle = new Circle(6);
			Rectangle rectangle = new Rectangle(4, 8);
			Console.WriteLine("Dairenin sahesi: " + circle.Area());
			Console.WriteLine("Duzbucaqlinin sahesi:" + rectangle.Area());*/
            #endregion

            #region Task 2
            Console.WriteLine("VISACARD");
            double balance = 500;
			VisaCard card = new VisaCard(balance);
			
            Console.WriteLine("Hesabdaki mebleg" +balance);
			Console.Write("Odenis etmek ucun meblegi daxil edin:");
			double amount= Convert.ToInt32(Console.ReadLine());
			card.Payment(amount);



            Console.WriteLine("MASTERCARD");
            double balance1 = 700;
			MasterCard masterCard = new MasterCard(balance1);
			Console.WriteLine("Hesabdaki mebleg" + balance1);
			Console.Write("Odenis etmek ucun meblegi daxil edin:");
			double amount1 = Convert.ToInt32(Console.ReadLine());
			#endregion

		}
	}
	#region Task1
	/*abstract class Shape
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


	}*/
	#endregion


	#region Task 2
	interface IBankCard
	{
		void Payment(double amount);
		double ChekBalance();
	}
	   public class VisaCard : IBankCard
	{
		private double balance;
		public VisaCard(double balance)
		{
			this.balance = balance;
		}

			public double ChekBalance()
		{
			return balance;
		}

		public void Payment(double amount)
		{
			if (amount > 0 && balance >= amount)
			{
				Console.WriteLine($"Odenis ugurla heyata kecdi");
			}
			else
			{
				Console.WriteLine($"Yetersiz balans");
			}
		}
	}
	class MasterCard : IBankCard
	{
		private double balance1;
		public MasterCard(double balance1)
		{ 
			this.balance1 = balance1; 
		}	

		public double ChekBalance()
		{
			return balance1;
		}

		public void Payment(double amount)
		{
			if (amount > 0 && balance1 >= amount)
			{
				Console.WriteLine($"Odenis ugurla heyata kecdi");
			}
			else
			{
				Console.WriteLine($"Yetersiz balans");
			}
		}
	}
}
#endregion
