/*
 * Created by SharpDevelop.
 * User: infomaniac50
 * Date: 11/3/2013
 * Time: 11:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace UdpIrDuino
{
	// Values for decode_type
	enum IrCodeType {
		NEC = 1,
		SONY = 2,
		RC5 = 3,
		RC6 = 4,
		DISH = 5,
		SHARP = 6,
		PANASONIC = 7,
		JVC = 8,
		SANYO = 9,
		MITSUBISHI = 10,
		UNKNOWN = -1,
	}


	[StructLayout(LayoutKind.Sequential)]
	struct IrCode
	{
		public UInt64 value;
		public Int16 nbits;
		public UInt32 ex1;
		public UInt32 ex2;
	}
	
	[StructLayout(LayoutKind.Sequential)]
	struct IrPacket
	{
		public Int16 type;
		public IrCode code;
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			ConsoleKey again = ConsoleKey.Enter;
			string line;
			ulong num;

			Console.WriteLine("Welcome to the UDP packet sender.");
			
			UdpClient client = new UdpClient();
			IPAddress ip = new IPAddress(new byte[] { 192, 168, 2, 88 });
			client.Connect(ip, 8888);
			
			while(again == ConsoleKey.Enter)
			{
				MakePacket(client);		
				Console.WriteLine("Press Enter to continue. Any thing else to quit.");
				again = Console.ReadKey().Key;
			}
		}

		public static void MakePacket(UdpClient client)
		{
			IrPacket packet = new IrPacket();

			Console.Write("Enter Code Type: ");
			switch (Console.ReadLine()) {
			case "NEC":
				packet.type = (Int16)IrCodeType.NEC;
				break;
			case "SONY":
				packet.type = (Int16)IrCodeType.SONY;
				break;
			case "RC5":
				packet.type = (Int16)IrCodeType.RC5;
				break;
			case "RC6":
				packet.type = (Int16)IrCodeType.RC6;
				break;
			case "DISH":
				packet.type = (Int16)IrCodeType.DISH;
				break;
			case "SHARP":
				packet.type = (Int16)IrCodeType.SHARP;
				break;
			case "PANASONIC":
				packet.type = (Int16)IrCodeType.PANASONIC;
				break;
			case "JVC":
				packet.type = (Int16)IrCodeType.JVC;
				break;
			default:
				break;
			}

			Console.WriteLine("Enter Bit Length");
			if(!Int16.TryParse(Console.ReadLine(), out packet.code.nbits))
			{
				Console.WriteLine ("Not a valid number.");
				return;
			}

			packet.code.nbits = Math.Abs(packet.code.nbits);

			Console.WriteLine("Enter an unsigned 64 bit integer.");


			if (!UInt64.TryParse(Console.ReadLine(), out packet.code.value))
			{
				Console.WriteLine("Not a valid number.");
			}

			BinaryFormatter bf = new BinaryFormatter();
			MemoryStream ms = new MemoryStream();
			bf.Serialize(ms, packet);
			client.Send(ms.ToArray(), System.Runtime.InteropServices.Marshal.SizeOf(packet));
		}

		// Convert an object to a byte array
		private static byte[] ObjectToByteArray(Object obj)
		{
		    if(obj == null)
		        return null;
		    BinaryFormatter bf = new BinaryFormatter();
		    MemoryStream ms = new MemoryStream();
		    bf.Serialize(ms, obj);
		    return ms.ToArray();
		}
	}
}