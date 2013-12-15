/*
 * Created by SharpDevelop.
 * User: infomaniac50
 * Date: 12/14/2013
 * Time: 4:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Numerics;
using UdpIrDuino.Utils;
using System.Net;

namespace UdpIrDuino
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		IPAddress ip;
		IrCode code;
		IrDuino ir;
		long txtBaseNumber;

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			cmbType.Items.AddRange(Enum.GetNames(typeof(IrCodeType)));
			
			btnSendCode.Click += new EventHandler(btnSendCode_Click);
			btnConnect.Click += new EventHandler(btnConnect_Click);
			btnDisconnect.Click += new EventHandler(btnDisconnect_Click);
			
			txtBase2.Leave += new EventHandler(UpdateFromBinary);
			txtBase8.Leave += new EventHandler(UpdateFromOctal);
			txtBase10.Leave += new EventHandler(UpdateFromDecimal);
			txtBase16.Leave += new EventHandler(UpdateFromHex);
			
			SetIpAddress("192.168.2.88");
			
			ir = new IrDuino(ip);
		}

		void UpdateConnectionStatus()
		{
			btnConnect.Enabled = !ir.IsConnected;
			btnDisconnect.Enabled = ir.IsConnected;
			btnSendCode.Enabled = ir.IsConnected;
		}

		void btnDisconnect_Click(object sender, EventArgs e)
		{
			ir.Disconnect();
			
			UpdateConnectionStatus();
		}

		void btnConnect_Click(object sender, EventArgs e)
		{
			ir.Connect();
			
			UpdateConnectionStatus();
		}

		bool SetIpAddress(string address)
		{
			return IPAddress.TryParse(address, out ip);
		}

		void UpdateToString()
		{
			txtBase2.Text = BaseConverter.ToString(txtBaseNumber, BaseConversions.Binary);
			txtBase8.Text = BaseConverter.ToString(txtBaseNumber, BaseConversions.Octal);
			txtBase10.Text = BaseConverter.ToString(txtBaseNumber, BaseConversions.Decimal);
			txtBase16.Text = BaseConverter.ToString(txtBaseNumber, BaseConversions.Hexadecimal);
		}

		void UpdateFromBinary(object sender, EventArgs e)
		{
			if (txtBase2.Text.Length > 0 && BaseConverter.IsNumber(txtBase2.Text, BaseConversions.Binary)) {
				txtBaseNumber = BaseConverter.FromString(txtBase2.Text, BaseConversions.Binary);
				UpdateToString();
			}
		}

		void UpdateFromOctal(object sender, EventArgs e)
		{
			if (txtBase8.Text.Length > 0 && BaseConverter.IsNumber(txtBase8.Text, BaseConversions.Octal)) {
				txtBaseNumber = BaseConverter.FromString(txtBase8.Text, BaseConversions.Octal);
				UpdateToString();
			}
		}

		void UpdateFromDecimal(object sender, EventArgs e)
		{
			if (txtBase10.Text.Length > 0 && BaseConverter.IsNumber(txtBase10.Text, BaseConversions.Decimal)) {
				txtBaseNumber = BaseConverter.FromString(txtBase10.Text, BaseConversions.Decimal);
				UpdateToString();	
			}
		}

		void UpdateFromHex(object sender, EventArgs e)
		{
			if (txtBase16.Text.Length > 0 && BaseConverter.IsNumber(txtBase16.Text, BaseConversions.Hexadecimal)) {
				txtBaseNumber = BaseConverter.FromString(txtBase16.Text, BaseConversions.Hexadecimal);
				UpdateToString();
			}
		}

		void btnSendCode_Click(object sender, EventArgs e)
		{
			IrCodeType type = (IrCodeType)Enum.Parse(typeof(IrCodeType), cmbType.SelectedItem.ToString());
			code = new IrCode();
			code.type = (short)type;

			if (short.TryParse(txtBits.Text, out code.nbits) && uint.TryParse(txtEx1.Text, out code.ex1) && uint.TryParse(txtEx2.Text, out code.ex2) && ulong.TryParse(txtValue.Text, out code.value)) {
				ir.SendCode(code);
			}
		}

		public void MakePacket()
		{
//			IrCode packet = new IrCode ();
//			if (!MakePacket (client, ref packet)) {
//				Console.WriteLine ("Invalid packet.");
//				return;
//			}
		}
		//
		//		private bool MakePacket (UdpClient client, ref IrCode packet)
		//		{
		//			Console.Write ("Enter Code Type: ");
		//			switch (Console.ReadLine ()) {
		//				case "NEC":
		//					packet.type = (Int16)IrCodeType.NEC;
		//					break;
		//				case "SONY":
		//					packet.type = (Int16)IrCodeType.SONY;
		//					break;
		//				case "RC5":
		//					packet.type = (Int16)IrCodeType.RC5;
		//					break;
		//				case "RC6":
		//					packet.type = (Int16)IrCodeType.RC6;
		//					break;
		//				case "DISH":
		//					packet.type = (Int16)IrCodeType.DISH;
		//					break;
		//				case "SHARP":
		//					packet.type = (Int16)IrCodeType.SHARP;
		//					break;
		//				case "PANASONIC":
		//					packet.type = (Int16)IrCodeType.PANASONIC;
		//					break;
		//				case "JVC":
		//					packet.type = (Int16)IrCodeType.JVC;
		//					break;
		//				default:
		//					Console.WriteLine("Not a valid code type");
		//					return false;
		//			}
		//
		//			Console.WriteLine ("Enter Bit Length");
		//			if (!Int16.TryParse (Console.ReadLine (), out packet.nbits)) {
		//				Console.WriteLine ("Not a valid number.");
		//				return false;
		//			}
		//
		//			packet.nbits = Math.Abs (packet.nbits);
		//
		//			Console.WriteLine("Enter ex1:");
		//			if (!UInt32.TryParse(Console.ReadLine(), out packet.ex1))
		//			{
		//				Console.WriteLine("Not a valid number.");
		//				return false;
		//			}
		//
		//			Console.WriteLine("Enter ex2:");
		//			if (!UInt32.TryParse(Console.ReadLine(), out packet.ex2))
		//			{
		//				Console.WriteLine("Not a valid number.");
		//				return false;
		//			}
		//
		//			Console.WriteLine ("Enter value:");
		//			if (!UInt64.TryParse (Console.ReadLine (), out packet.value)) {
		//				Console.WriteLine ("Not a valid number.");
		//				return false;
		//			}
		//
		//			return true;
		//		}
	}
}
