using System;

namespace Module_Two
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i=0; i<8; i++)
			{
				String Block;

				if (i % 2 == 0)
					Block = "XO";
				else
					Block = "OX";

				for (int r=0; r<8; r++)
				{
					Console.Write(Block);
				}

				Console.WriteLine();
			}

		}
	}
}
