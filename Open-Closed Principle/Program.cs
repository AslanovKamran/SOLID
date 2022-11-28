namespace Open_Closed_Principle
{
	#region Bad Example 

	//internal class Cook
	//{
	//	public string Name { get; set; } = string.Empty;
	//	public Cook(string name) => this.Name = name;

	//	public void CookDinner()
	//	{
	//		Console.WriteLine("Peeling potatoes...");
	//		Console.WriteLine("Cutting potatoes...");
	//		Console.WriteLine("Boiling potatoes...");
	//		Console.WriteLine("Mash potatoes...");
	//		Console.WriteLine("Done!");
	//	}
	//}
	//internal class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		Cook cook1 = new Cook("John");
	//		cook1.CookDinner();
	//	}
	//}
	#endregion

	#region Good Example (Strategy Pattern)

	//internal interface IMeal
	//{
	//	void MakeIt();
	//}

	//internal class MashedPotatoes : IMeal
	//{
	//	public void MakeIt()
	//	{
	//		Console.WriteLine("Peeling potatoes...");
	//		Console.WriteLine("Cutting potatoes...");
	//		Console.WriteLine("Boiling potatoes...");
	//		Console.WriteLine("Mash potatoes...");
	//		Console.WriteLine("Done!");
	//	}
	//}
	//internal class VegetarianSalad : IMeal
	//{
	//	public void MakeIt()
	//	{
	//		Console.WriteLine("Washing vegetables...");
	//		Console.WriteLine("Peeling vegetables...");
	//		Console.WriteLine("Dicing vegetavles...");
	//		Console.WriteLine("Seasoning vegetables...");
	//		Console.WriteLine("Done!");
	//	}
	//}

	//internal class Cook
	//{
	//	public string Name { get; set; } = string.Empty;
	//	public Cook(string name) => this.Name = name;

	//	public void CookDinner(IMeal meal)
	//	{
	//		meal.MakeIt();
	//	}
	//}

	//internal class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		var bob = new Cook("Bob");
	//		bob.CookDinner(new MashedPotatoes());
	//		bob.CookDinner(new VegetarianSalad());
	//	}
	//}

	#endregion

	#region Good Example (Template Method Pattern)

	//internal abstract class MealBase
	//{
	//	public void Make()
	//	{
	//		Prepare();
	//		Cook();
	//		FinalSteps();
	//	}
	//	protected abstract void Prepare();
	//	protected abstract void Cook();
	//	protected abstract void FinalSteps();
	//}

	//internal class MashedPotatoes : MealBase
	//{
	//	protected override void Prepare()
	//	{
	//		Console.WriteLine("Peeling potatoes...");
	//		Console.WriteLine("Cutting potatoes...");
	//	}
	//	protected override void Cook()
	//	{
	//		Console.WriteLine("Boiling potatoes...");
	//		Console.WriteLine("Mash potatoes...");
	//	}

	//	protected override void FinalSteps()
	//	{
	//		Console.WriteLine("Done!\n");
	//	}
	//}
	//internal class VegetarianSalad : MealBase
	//{
	//	protected override void Prepare()
	//	{
	//		Console.WriteLine("Washing vegetables...");
	//		Console.WriteLine("Peeling vegetables...");
	//	}
	//	protected override void Cook()
	//	{
	//		Console.WriteLine("Dicing vegetavles...");
	//		Console.WriteLine("Seasoning vegetables...");
	//	}

	//	protected override void FinalSteps()
	//	{
	//		Console.WriteLine("Done!\n");
	//	}
	//}
	//internal class VegetarianSaladWithCheese : VegetarianSalad
	//{
	//	protected override void FinalSteps()
	//	{
	//		Console.WriteLine("Adding Chesse...");
	//		Console.WriteLine("Done!\n");
	//	}
	//}

	//internal class Cook
	//{
	//	public string Name { get; set; } = string.Empty;
	//	public Cook(string name) => this.Name = name;

	//	public void CookDinner(MealBase[] menu)
	//	{
	//		foreach (var item in menu)
	//			item.Make();
	//	}
	//}

	//internal class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		MealBase[] menu = new MealBase[] { new MashedPotatoes(), new VegetarianSalad(), new VegetarianSaladWithCheese() };
	//		Cook bob = new Cook("Bob");
	//		bob.CookDinner(menu);
	//	}
	//}

	#endregion

}