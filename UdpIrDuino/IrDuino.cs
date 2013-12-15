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
using System.Runtime.Serialization;
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


	// struct IrCode
	// {
	//   unsigned long long value;
	//   int nbits;
	//   unsigned long ex1;
	//   unsigned long ex2;
	// };

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack=1)]
	struct IrCode
	{
		public Int16 type;
		public Int16 nbits;
		public UInt32 ex1;
		public UInt32 ex2;
		public UInt64 value;
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			ConsoleKey again = ConsoleKey.Enter;

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

		public static void MakePacket (UdpClient client)
		{
			IrCode packet = new IrCode ();

			Console.Write ("Enter Code Type: ");
			switch (Console.ReadLine ()) {
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

			Console.WriteLine ("Enter Bit Length");
			if (!Int16.TryParse (Console.ReadLine (), out packet.nbits)) {
				Console.WriteLine ("Not a valid number.");
				return;
			}

			packet.nbits = Math.Abs (packet.nbits);

			Console.WriteLine ("Enter an unsigned 64 bit integer.");


			if (!UInt64.TryParse (Console.ReadLine (), out packet.value)) {
				Console.WriteLine ("Not a valid number.");
			}



			unsafe {
				byte[] arr = Serialize(packet);
				client.Send(arr, Marshal.SizeOf(packet));
			}

		}

		/// <summary>
	    /// Serializes the specified object into a byte array.
	    /// </summary>
	    /// <param name="nativeObject">The object to serialize.</param>
	    /// <returns></returns>
	    public static byte[] Serialize(object obj)
	    {
	        //Type objectType = obj.GetType();
	        int objectSize = Marshal.SizeOf(obj);
	        IntPtr buffer = Marshal.AllocHGlobal(objectSize);
	        Marshal.StructureToPtr(obj, buffer, false);
	        byte[] array = new byte[objectSize];
	        Marshal.Copy(buffer, array , 0, objectSize);
	        Marshal.FreeHGlobal(buffer);
	        return array;
	    }
	}
}