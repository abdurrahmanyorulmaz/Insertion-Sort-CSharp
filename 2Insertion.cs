using System;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Insertion_Sort_Abdurrahman_YORULMAZ");
			int elements;
			Console.WriteLine("Write how many elements you want to enter the array:");
			elements = Convert.ToInt32(Console.ReadLine());
			int[] array = new int[elements];
			Console.WriteLine("\nEnter " + elements + " numbers.\n");
			for (int counter = 0; counter < elements; counter++)
			{
				Console.WriteLine("Enter the element to be kept in the " + counter + ". Index");
				array[counter] = Convert.ToInt32(Console.ReadLine());
			}
			Console.Write("\n\nThe first version of the series: ");
			foreach (int value in array)
			{
				Console.Write(value + " ");
			}
			Console.WriteLine();
			sort(array);
			write(array);
		}
		public static void write(int[] array)
		{
			Console.Write("The series in ascending order: ");
			foreach (int value in array)
			{
				Console.Write(value + " ");
			}
			Console.WriteLine("\n\n>>Press any key to exit.");
			Console.ReadKey();
		}
		public static void sort(int[] array)
		{
			int holder;
			for (int j = 1; j < array.Length; j++)
			{
				int holder = array[j];
				int i = j - 1;
				while (i >= 0 && array[i] > holder)
				{
					array[i + 1] = array[i];
					i = i - 1;
				}
				array[i + 1] = holder;
			}
		}
	}
}