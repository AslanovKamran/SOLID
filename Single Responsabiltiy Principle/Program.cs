namespace Single_Responsabiltiy_Principle
{


	#region Bad Example of Single Reponsability #1

	//internal class Report
	//{
	//	public string Text { get; set; } = string.Empty;

	//	public Report(){}
	//	public Report(string _text)=>this.Text = _text;

	//	public void NavigateToPageOne() => Console.WriteLine("You are at the page 1");
	//	public void NavigateToLastPage() => Console.WriteLine("You are at the last page");
	//	public void NavigateToNthPage(int pageNum) => Console.WriteLine($"You are at the page {pageNum}");

	//	public void Print()
	//	{
	//		Console.WriteLine("Printing the page ...");
	//		Console.WriteLine(this.Text);
	//	}
	//}
	//internal class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		Report report = new Report(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit.
	//									Curabitur fermentum sapien at nibh molestie lacinia. Maecenas tempus sapien ante.\n
	//									Lectus elit euismod velit, quis congue magna erat at risus. Vivamus vestibulum feugiat nunc.");
	//		report.Print();
	//	}
	//}

	#endregion

	#region Good Example of Single Reponsability #1

	//internal interface IPrinter
	//{
	//	void PrintText(string _text);
	//}

	//internal class LaserPrinter : IPrinter
	//{
	//	public void PrintText(string _text)
	//	{
	//		Console.WriteLine("Printing via laser printer...");
	//		Console.WriteLine(_text);
	//	}
	//}

	//internal class InkjetPrinter : IPrinter
	//{
	//	public void PrintText(string _text)
	//	{
	//		Console.WriteLine("Printing via inkjet printer...");
	//		Console.WriteLine(_text);
	//	}
	//}

	//internal class Report
	//{
	//	public string Text { get; set; } = string.Empty;

	//	public Report() { }
	//	public Report(string _text) => this.Text = _text;

	//	public void NavigateToPageOne() => Console.WriteLine("You are at the page 1");
	//	public void NavigateToLastPage() => Console.WriteLine("You are at the last page");
	//	public void NavigateToNthPage(int pageNum) => Console.WriteLine($"You are at the page {pageNum}");

	//	public void Print (IPrinter printer)
	//	{
	//		printer.PrintText(this.Text);
	//	}


	//}
	//internal class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		Report report = new Report(@"Default Input");

	//		report.Print(new LaserPrinter());
	//		//report.Print(new InkjetPrinter());

	//	}
	//}

	#endregion




	#region Bad Example of Single Reponsability #2

	//internal class Phone
	//{
	//	public string Model { get; set; }
	//	public double Price { get; set; }

	//	public Phone()
	//	{
	//		this.Model = string.Empty;
	//		this.Price = default;
	//	}

	//	public Phone(string model, double price) : base()
	//	{
	//		Model = model;
	//		Price = price;
	//	}

	//}


	//class PhoneStore
	//{
	//	List<Phone> phones = new List<Phone>();

	//	public void Process()
	//	{
	//		Console.Write("Input model: ");
	//		var model = Console.ReadLine();
	//		Console.Write("\nInput price: ");
	//		double price = default;
	//		bool result = Double.TryParse(Console.ReadLine(), out price);

	//		if (result == false || String.IsNullOrEmpty(model))
	//		{
	//			throw new Exception("Wrong Data");
	//		}
	//		else
	//		{
	//			phones.Add(new Phone(model, price));
	//			using (StreamWriter writer = new StreamWriter("store.txt", true))
	//			{
	//				writer.WriteLine(model);
	//				writer.WriteLine(price);
	//			}
	//			Console.WriteLine("\nSuccessfully added");
	//		}

	//	}
	//}


	//internal class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		PhoneStore store = new();
	//		try { store.Process(); }
	//		catch (Exception ex) { Console.WriteLine(ex.Message); }

	//	}
	//}


	#endregion

	#region Good Example of Single Reponsability #2

	//internal interface IPhoneReader
	//{
	//	string[] GetData();
	//}
	//internal interface IPhoneValidator
	//{
	//	Phone ValidateAndReturn(string[] phoneEntity);
	//}
	//internal interface IPhoneSaver
	//{
	//	void Save(Phone phone, string path);
	//}

	//internal class ConsoleReader : IPhoneReader
	//{
	//	public string[] GetData()
	//	{
	//		Console.Write("Input model: ");
	//		var model = Console.ReadLine();
	//		Console.Write("\nInput price: ");
	//		var price = Console.ReadLine();
	//		return new string[] { model, price };
	//	}
	//}
	//internal class PhoneValidator : IPhoneValidator
	//{
	//	public Phone ValidateAndReturn(string[] phoneEntity)
	//	{
	//		if (phoneEntity.Length >= 2 && !String.IsNullOrWhiteSpace(phoneEntity[0]))
	//		{
	//			double price = default;
	//			return Double.TryParse(phoneEntity[1], out price) ? new Phone(phoneEntity[0], price) : throw new Exception("Wrong Data");
	//		}

	//		else
	//		{
	//			throw new Exception("Lack of Data");
	//		}

	//	}
	//}
	//internal class TxtFormatSaver : IPhoneSaver
	//{
	//	public void Save(Phone phone, string path)
	//	{
	//		using (StreamWriter writer = new StreamWriter(path, true))
	//		{
	//			writer.WriteLine(phone.Model);
	//			writer.WriteLine(phone.Price);
	//		}
	//	}
	//}

	//internal class Phone
	//{
	//	public string Model { get; set; }
	//	public double Price { get; set; }

	//	public Phone()
	//	{
	//		this.Model = string.Empty;
	//		this.Price = default;
	//	}

	//	public Phone(string model, double price) : base()
	//	{
	//		Model = model;
	//		Price = price;
	//	}

	//}
	//internal class PhoneStore
	//{
	//	public IPhoneReader Reader { get; set; }
	//	public IPhoneSaver Saver { get; set; }
	//	public IPhoneValidator Validator { get; set; }

	//	public PhoneStore(IPhoneReader reader, IPhoneSaver saver, IPhoneValidator validator)
	//	{
	//		Reader = reader;
	//		Saver = saver;
	//		Validator = validator;
	//	}

	//	public void Process()
	//	{
	//		var data = Reader.GetData();
	//		var phoneEntity = Validator.ValidateAndReturn(data);
	//		Saver.Save(phoneEntity, "store.txt");
	//	}
	//}

	//internal class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		IPhoneReader phoneReader = new ConsoleReader();
	//		IPhoneValidator phoneValidator = new PhoneValidator();
	//		IPhoneSaver phoneSaver = new TxtFormatSaver();
	//		PhoneStore store = new PhoneStore(phoneReader, phoneSaver, phoneValidator);
	//		try { store.Process(); }
	//		catch (Exception ex) { Console.WriteLine(ex.Message); }
	//	}
	//}

	#endregion


}