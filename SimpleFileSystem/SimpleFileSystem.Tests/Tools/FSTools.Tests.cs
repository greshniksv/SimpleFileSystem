using System;
using NUnit.Framework;
using SimpleFileSystem.Tools;

namespace SimpleFileSystem.Tests.Tools
{

	[TestFixture]
	class FSToolsTestCase
	{
		[Test]
		public void LongToByte_CorrectConvertData()
		{
			const long data = 100500;
			var bytes = FSTools.LongToByte(data);
			byte[] correctBytes = {148, 136, 1, 0, 0};
			Assert.AreEqual(bytes, correctBytes);
		}

		[Test]
		public void ByteToLong() {
			const long data = 100500;
			byte[] bytes = { 148, 136, 1, 0, 0 };
			long result = FSTools.ByteToLong(bytes);
			Assert.AreEqual(data, result);
		}

		[Test]
		public void LongToByte_() {
			const long data = 1005009864313544315;
			Assert.Throws<Exception>(() => FSTools.LongToByte(data));
		}

		[Test]
		public void ByteToLong_ThrowsException() {
			byte[] bytes = { 148, 136, 1, 0, 0, 0 };
			Assert.Throws<Exception>(() => FSTools.ByteToLong(bytes));
		}

	}
}
