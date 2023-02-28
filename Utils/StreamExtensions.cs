using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArdEepromProgrammer.Utils
{
	public static class StreamExtensions
	{
		static bool FilesAreEqual(FileInfo first, FileInfo second)
		{
	
			if (string.Equals(first.FullName, second.FullName, StringComparison.OrdinalIgnoreCase))
				return true;

		

			using (FileStream fs1 = first.OpenRead())
			using (FileStream fs2 = second.OpenRead())
			{
				
			}

			return true;
		}

		public static bool CompareTo(this Stream first, Stream second, int bufferSize, Action<int> progressInfo)
		{
			if (first.Length != second.Length)
				return false;


			float iterations = (float)Math.Ceiling((double)first.Length / bufferSize);

			byte[] one = new byte[bufferSize];
			byte[] two = new byte[bufferSize];

			for (float i = 0; i < iterations; i++)
			{
				float perc = (i / iterations) * 100;

				first.Read(one, 0, bufferSize);
				second.Read(two, 0, bufferSize);

				progressInfo?.Invoke((int)perc);

				if (BitConverter.ToInt64(one, 0) != BitConverter.ToInt64(two, 0))
					return false;
			}

			return true;
		}

		public static void CopyTo(this SerialPort fromStream, Stream destination, int bufferSize, Action<int> progressInfo)
		{

			while (fromStream.BytesToRead < bufferSize) Thread.Sleep(10); // Waits for a least some data to come

			var buffer = new byte[bufferSize];
			int count;
			int transferred = 0;

			while (fromStream.BytesToRead > 0)
			{
				count = fromStream.Read(buffer, 0, buffer.Length);
				transferred += count;
				destination.Write(buffer, 0, count);
				progressInfo?.Invoke(transferred);

				if(bufferSize > fromStream.BytesToRead)
				{
					buffer = new byte[fromStream.BytesToRead]; // Trim the Buffer Length to Only the BytesToRead
				}

				if(fromStream.BytesToRead == 0)
				{
					Thread.Sleep(100); // Wait for the Programmer
				}
			}
		}
	}
}
