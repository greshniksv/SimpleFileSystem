using System;

namespace SimpleFileSystem.Tools
{
	public static class FSTools
	{
		private static readonly long[] SizeArr = { 4294967296, 16777216, 65536, 256 };

		public static long ByteToLong(byte[] bytes)
		{
			if (bytes.Length != 5)
			{
				throw new Exception("Incorrect bytes parameter");
			}
			long result = 0;
			for (int i = 0; i < bytes.Length; i++)
			{
				long added = 0;
				if (i != 0)
				{
					added = bytes[i] * SizeArr[4 - i];
				}
				else
				{
					added = bytes[i];
				}
				result += added;
			}
			return result;
		}

		public static byte[] LongToByte(long data) {
			var bytes = new byte[5];
			for (int i = 0; i < SizeArr.Length; i++) {
				int result = (int)(data / SizeArr[i]);
				if (result > 256) {
					throw new Exception("To big size!!!");
				}
				bytes[4 - i] = (byte)result;
				data = data - (SizeArr[i] * result);
			}
			bytes[0] = (byte)data;
			return bytes;
		}

	}
}
