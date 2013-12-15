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
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	public struct IrCode
	{
		public Int16 type;
		public Int16 nbits;
		public UInt32 ex1;
		public UInt32 ex2;
		public UInt64 value;
	}
}