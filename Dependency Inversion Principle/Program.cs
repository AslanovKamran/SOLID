namespace Dependency_Inversion_Principle
{
	#region Bad 

	//internal class File 
	//{
	//	public string Text { get; set; } = string.Empty;
	//	public ConsolePrinter Printer { get; set; } = new();

	//	public void Print()
	//	{
	//		Printer.PrintText(this.Text);
	//	}
	//}

	//internal class ConsolePrinter
	//{
	//	public void PrintText(string _text) => Console.WriteLine(_text);
	//}


	//internal class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		File file = new File();
	//		file.Text = "Default Text";
	//		file.Print();
	//	}
	//}
	#endregion

	#region Good

	//internal interface IPrinter
	//{
	//	void PrintText(string text);
	//}

	//internal class ConsolePrinter : IPrinter
	//{
	//	public void PrintText(string _text) => Console.WriteLine(_text);
	//}

	//internal class File
	//{
	//	public string Text { get; set; } = string.Empty;
	//	private IPrinter? Printer { get; set; }

	//	public File(IPrinter printer) => Printer = printer;

	//	public void SetPrinter(IPrinter printer) => Printer = printer;
	//	public void Print() => Printer?.PrintText(this.Text);
	//}

	//internal class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		File file = new File(new ConsolePrinter());
	//		file.Text = "Default Text";
	//		file.Print();
	//	}
	//}

	#endregion
}