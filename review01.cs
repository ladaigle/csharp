using System;

namespace FirstReview{

	public class MainClass{
	
		public static void main(string[] args){
			
			//01_
			Console.WriteLine("My name is Drew");
			Console.ReadKey();
			Console.WriteLine("My favorite color is blue");
			Console.ReadKey();
			
			//02_
			int num1, num2;
			
			Console.Write("Enter an integer: ");
			num1= Convert.ToInt32( Console.ReadLine() );
			Console.Write("Enter another integer: ");
			num2= Convert.ToInt32( Console.ReadLine() );
			
			Console.WriteLine(num1 " multiplied by " + num2 + " is: " + (num1*num2) );
			Console.ReadKey();
			
			//03_
			Random rand = new Random();
			int num1, num2, answer;
			
			num1= rand.Next(1, 11);
			num2= rand.Next(1, 11);
			
			Console.Write("What is " + num1 + " multiplied by " + num2 + " ? ");
			answer= Convert.ToInt32( Console.ReadLine() );
			
			if(answer == num1*num2){
				Console.WriteLine("Correct.");
			}
			else{
				Console.WriteLine("Incorrect.");
			}
			
			Console.ReadKey();
		}
	}
}