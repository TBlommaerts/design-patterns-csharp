using System;

namespace Facade
{
    public class BitrateReader
    {
		public static byte[] read(String filename, DecompressionCodec sourceCodec)
		{
			Console.WriteLine("Reading file: " + filename + " using codec.");
			// Dummy value
			return new byte[] { };
		}

		public static VideoFile convert(String filename, byte[] buffer, CompressionCodec destinationCodec)
		{
			Console.WriteLine("Converting buffer to the destination format.");
			return new VideoFile(filename);
		}
	}
}
