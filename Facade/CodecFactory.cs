using System;

namespace Facade
{
    public class CodecFactory
    {
		public DecompressionCodec extract(VideoFile file)
		{
			Console.WriteLine("Extracting file: " + file.GetFilename());
			// Actual logic here to figure out the correct codec
			bool someLogic = true;
			if (someLogic)
			{
				return new OggDecompressionCodec();
			}
			else
			{
				return new MPEG4DecompressionCodec();
			}
		}
	}
}
