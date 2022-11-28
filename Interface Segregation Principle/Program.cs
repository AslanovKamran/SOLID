using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Interface_Segregation
{
	#region BAD

	//internal interface IMessage
	//{
	//	void Send();

	//	string Text { get; set; }
	//	string Subject { get; set; }
	//	string ToAddress { get; set; }
	//	string FromAddress { get; set; }
	//}

	//internal class EmailMessage : IMessage
	//{
	//	public string Subject { get; set; } = string.Empty;
	//	public string Text { get; set; } = string.Empty;
	//	public string FromAddress { get; set; } = string.Empty;
	//	public string ToAddress { get; set; } = string.Empty;

	//	public void Send() => Console.WriteLine($"Sending {Text} via  Email");
	//}

	//internal class SmsMessage : IMessage
	//{
	//	public string Text { get; set; }		= string.Empty;
	//	public string FromAddress { get; set; }	= string.Empty;
	//	public string ToAddress { get; set; } = string.Empty;

	//	public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	//	public void Send() => Console.WriteLine($"Sending {Text} via Sms");
	//}

	//internal interface IMessage2
	//{
	//	void Send();
	//	string Text { get; set; }
	//	string ToAddress { get; set; }
	//	string Subject { get; set; }
	//	string FromAddress { get; set; }

	//	byte[] Voice { get; set; }
	//}

	//internal class VoiceMessage : IMessage2
	//{
	//	public string ToAddress { get; set; } = string.Empty;
	//	public string FromAddress { get; set; } = String.Empty;
	//	public byte[] Voice { get; set; } = new byte[255];

	//	public string Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	//	public string Subject  { get => throw new NotImplementedException(); set => throw new NotImplementedException();
	//	public void Send() => Console.WriteLine("Sending voice message");
	//}

	#endregion

	#region GOOD
	internal interface IMessage
	{
		void Send();
		string ToAddress { get; set; }
		string FromAddress { get; set; }
	}

	internal interface IVoiceMessage : IMessage
	{
		byte[] Voice { get; set; }
	}

	internal interface ITextMessage : IMessage
	{
		string Text { get; set; }
	}



	internal interface IEmailMessage : ITextMessage
	{
		string Subject { get; set; }
	}

	internal class VoiceMessage : IVoiceMessage
	{
		public string ToAddress { get; set; } = string.Empty;
		public string FromAddress { get; set; } = string.Empty;

		public byte[] Voice { get; set; } = new byte[255];
		public void Send() => Console.WriteLine("Sending voice message");

	}
	internal class EmailMessage : IEmailMessage
	{
		public string Text { get; set; } = string.Empty;
		public string Subject { get; set; } = string.Empty;
		public string FromAddress { get; set; } = string.Empty;
		public string ToAddress { get; set; } = string.Empty;

		public void Send() => Console.WriteLine($"Sending {Text} via  Email");
	}

	internal class SmsMessage : ITextMessage
	{
		public string Text { get; set; } = string.Empty;
		public string FromAddress { get; set; } = string.Empty;
		public string ToAddress { get; set; } = string.Empty;
		public void Send() => Console.WriteLine($"Sending {Text} via Sms");
	}
	#endregion
}