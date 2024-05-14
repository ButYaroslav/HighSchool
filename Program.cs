using System.Text;
using System.Xml.Linq;

namespace HighSchool;

internal class Program
{
	static void Main()
	{
		Console.InputEncoding = Encoding.GetEncoding("UTF-16");
		Console.OutputEncoding = Encoding.GetEncoding("UTF-16");

		Console.Write("Введіть назву навчального закладу: ");
		string? Name = Console.ReadLine();
		Console.WriteLine($"Назва закладу: {Name}\n");

		Console.Write("Введіть кількість студентів, зарахованих на 1-й курс: ");
		double QuantityFristCourse = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Кількість студентів на 1-му курсі:: {QuantityFristCourse}\n");

		Console.Write("Введіть кількість випускників: ");
		double Graduate = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Кількість випускників: {Graduate}\n");

		Console.Write("Введіть кількість випускників, які працюють за фахом: ");
		double GraduateWorkInSpeciality = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Кількість випускників, які працюють за фахом: {GraduateWorkInSpeciality}\n");

		Solution s1 = new Solution(QuantityFristCourse, Graduate, GraduateWorkInSpeciality);
		s1.Info();
		double solution = s1.GetSolution();
		Console.WriteLine($"Обчисленне рішення = {solution}\n\n");
	}
}
public class Solution 
{		
	protected double _quantityFristCourse;
	protected double _graduate;
	protected double _graduateWorkInSpeciality;

	public Solution(double quantityFristCourse, double graduate, double graduateWorkInSpeciality)
	{
		_quantityFristCourse = quantityFristCourse;
		_graduate = graduate;
		_graduateWorkInSpeciality = graduateWorkInSpeciality;
	}

	public void Info()
	{
		Console.WriteLine($"Кількість студентів на 1-му курсі: {_quantityFristCourse}, Кількість випускників: {_graduate}, Кількість випускників, які працюють за фахом: {_graduateWorkInSpeciality}\n ");
	}
	public double GetP()
	{
		double p = (_graduate * 100) / _graduateWorkInSpeciality;
		return p;
	}

	public double GetQ()
	{
		double q = _graduate / _quantityFristCourse;
		return q;
	}
	public double GetSolution()
	{
		double solution = (GetP() * GetQ());
		return solution;
	}
}
	