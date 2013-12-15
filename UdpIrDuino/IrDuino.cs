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
	public class IrDuino
	{
		private UdpClient client;
		private IPAddress ip;

		public IrDuino(IPAddress ip)
		{
			this.ip = ip;
			IsConnected = false;
		}

		~IrDuino()
		{
			ip = null;
			client = null;
		}

		public bool IsConnected {
			get;
			private set;
		}

		public bool Connect()
		{
			if (!IsConnected) {
				try {
					client = new UdpClient();
					client.Connect(ip, 8888);
					IsConnected = true;
				} catch (Exception) {
					client = null;
					IsConnected = false;
				}
			}			
			
			return IsConnected;
		}

		public bool Disconnect()
		{
			if (IsConnected) {
				try {
					client.Close();
				} catch (Exception) {
					throw;
				} finally {
					client = null;
					IsConnected = false;
				}
			}
			
			return IsConnected;
		}

		public void SendCode(IrCode code)
		{
			int packet_size;
			byte[] arr;

			if (IsConnected) {
				packet_size = Serialize(code, out arr);
				client.Send(arr, packet_size);
			}
		}

		/// <summary>
		/// Serializes the specified object into a byte array.
		/// </summary>
		/// <param name="nativeObject">The object to serialize.</param>
		/// <returns></returns>
		public unsafe static int Serialize(object obj, out byte[] array)
		{
			int objectSize = Marshal.SizeOf(obj);
			IntPtr buffer = Marshal.AllocHGlobal(objectSize);
			Marshal.StructureToPtr(obj, buffer, false);
			array = new byte[objectSize];
			Marshal.Copy(buffer, array, 0, objectSize);
			Marshal.FreeHGlobal(buffer);
			return objectSize;
		}
	}
}