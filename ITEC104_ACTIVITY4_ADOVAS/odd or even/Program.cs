﻿using System;

namespace Activity4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] element = {3,6,9,12,15};
			Console.WriteLine("==ARRAY PROGRAM==");
			Console.WriteLine("Enter Element[0]= {0}",element[0]);
			Console.WriteLine("Enter Element[1]= {0}",element[1]);
			Console.WriteLine("Enter Element[2]= {0}",element[2]);
			Console.WriteLine("Enter Element[3]= {0}",element[3]);
			Console.WriteLine("Enter Element[4]= {0}",element[4]);
			Console.WriteLine("Odd Numbers: {0}, {1}, {2}.",element[0],element[2],element[4]);
			Console.WriteLine("Even Numbers: {0}, {1}.",element[1],element[3]);
			Console.ReadKey();
		}
	}
}