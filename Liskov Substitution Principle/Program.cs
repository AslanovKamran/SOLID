namespace Liskov_Substitution_Principle
{
	#region Bad Example

	//internal class Rectangle
	//{
	//	public virtual int Height { get; set; } = 1;
	//	public virtual int Width { get; set; } = 1;
	//	public Rectangle() { }
	//	public Rectangle(int _h, int _w)
	//	{
	//		this.Height = _h;
	//		this.Width = _w;
	//	}
	//	public int GetArea() => Height * Width;
	//}

	//internal class Square : Rectangle
	//{
	//	public override int Width { get => base.Width; set { base.Width = value; base.Height = value; } }
	//	public override int Height { get => base.Height; set { base.Height = value; base.Width = value; } }
	//}

	//internal class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		Rectangle figure_inh = new Square();			
	//		Rectangle figure = new Rectangle();			

	//		Console.WriteLine(TestArea(figure_inh)); //false
	//		Console.WriteLine(TestArea(figure));	 //true
	//	}

	//	//Test doens't work correctly for "Square class"
	//	private static bool TestArea(Rectangle rectangle)
	//	{
	//		rectangle.Height = 5;
	//		rectangle.Width = 10;
	//		return rectangle.GetArea() == 50;
	//	}
	//	//Solution - Remove Inheritance
	//}

	#endregion
}