using System;

namespace Module_One
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			String FirstName = "Md. Minhazul";
			String LastName = "Haque";
			DateTime Birthdate = new DateTime(1992, 1, 23);
			String AddressLine1 = "House 123/C";
			String AddressLine2 = "Word 13";
			String City = "Rajshahi";
			String State = "Rajshahi";
			int Postal = 6000;
			String Country = "Bangladesh";
			String Degree = "Bachelor";
			String Program = "Computer Science and Engineering";
			String Course = "DEV204x Programming with C#";

			Console.WriteLine("First Name: " + FirstName);
			Console.WriteLine("LastName: " + LastName);
			Console.WriteLine("Birthdate: " + Birthdate.Year + "/" + Birthdate.Month + "/" + Birthdate.Day);
			Console.WriteLine("Address Line1: " + AddressLine1);
			Console.WriteLine("Address Line2: " + AddressLine2);
			Console.WriteLine ("City: " + City);
			Console.WriteLine ("State: " + State);
			Console.WriteLine ("Postal: " + Postal);
			Console.WriteLine ("Country: " + Country);
			Console.WriteLine ("Degree: " + Degree);
			Console.WriteLine ("Program: " + Program);
			Console.WriteLine ("Course: " + Course);
		}
	}
}
