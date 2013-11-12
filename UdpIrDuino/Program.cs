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

namespace UdpIrDuino
{
	[StructLayout(LayoutKind.Sequential)]
	struct IrCode
	{
		
	}
	
	[StructLayout(LayoutKind.Sequential)]
	struct IrPacket
	{
		
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
				Console.WriteLine("Enter an unsigned 64 bit integer.");
				line = Console.ReadLine();
				if (ulong.TryParse(line, out num))
				{
					byte[] bits = BitConverter.GetBytes(num);
					client.Send(bits, sizeof(ulong));
				}
				else
				{
					Console.WriteLine("Not a valid number.");
				}
				
				Console.WriteLine("Press Enter to continue. Any thing else to quit.");
				again = Console.ReadKey().Key;
			}
		}
	}
}