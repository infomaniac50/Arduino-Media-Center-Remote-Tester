using System;
using System.Text.RegularExpressions;

namespace UdpIrDuino.Utils
{
	public enum BaseConversions {
		Binary,
		Octal,
		Decimal,
		Hexadecimal,
	}
	
	public static class BaseConverter
	{
		static Regex regexBinary;
		static Regex regexOctal;
		static Regex regexDecimal;
		static Regex regexHex;

		static BaseConverter()
		{
			regexBinary = new Regex("^[0-1]*$", RegexOptions.Compiled);
			regexOctal = new Regex("^[0-7]*$", RegexOptions.Compiled);
			regexDecimal = new Regex("^[0-9]*$", RegexOptions.Compiled);
			regexHex = new Regex("^[0-9a-fA-F]*$", RegexOptions.Compiled);
		}
		
		public static bool IsNumber(string number, BaseConversions numberBase)
		{
			bool result;
			
			switch (numberBase) {
				case BaseConversions.Binary:
					result = regexBinary.IsMatch(number);
					break;
				case BaseConversions.Octal:
					result = regexOctal.IsMatch(number);
					break;
				case BaseConversions.Decimal:
					result = regexDecimal.IsMatch(number);
					break;
				case BaseConversions.Hexadecimal:
					result = regexHex.IsMatch(number);
					break;
				default:
					throw new Exception("Invalid value for BaseConversions");
			}
			
			return result;
		}
		
		public static bool IsBinary(string number)
		{
			return IsNumber(number, BaseConversions.Binary);
		}
		
		public static bool IsOctal(string number)
		{
			return IsNumber(number, BaseConversions.Octal);
		}
		
		public static bool IsDecimal(string number)
		{
			return IsNumber(number, BaseConversions.Decimal);
		}

		public static bool IsHex(string number)
		{
			return IsNumber(number, BaseConversions.Hexadecimal);
		}
		
		public static string ToString(long number, BaseConversions numberBase)
		{
			string result;
			
			switch (numberBase) {
				case BaseConversions.Binary:
					result = Convert.ToString(number, 2);
					break;
				case BaseConversions.Octal:
					result = Convert.ToString(number, 8);
					break;
				case BaseConversions.Decimal:
					result = Convert.ToString(number, 10);
					break;
				case BaseConversions.Hexadecimal:
					result = Convert.ToString(number, 16);
					break;
				default:
					throw new Exception("Invalid value for BaseConversions");
			}

			return result;
		}

		public static long FromString(string number, BaseConversions numberBase)
		{
			long result;

			switch (numberBase) {
				case BaseConversions.Binary:
					result = Convert.ToInt64(number, 2);
					break;
				case BaseConversions.Octal:
					result = Convert.ToInt64(number, 8);
					break;
				case BaseConversions.Decimal:
					result = Convert.ToInt64(number, 10);
					break;
				case BaseConversions.Hexadecimal:
					result = Convert.ToInt64(number, 16);
					break;
				default:
					throw new Exception("Invalid value for BaseConversions");
			}

			return result;
		}
	}
}

