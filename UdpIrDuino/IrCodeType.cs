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
	public enum IrCodeType
	{
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
}