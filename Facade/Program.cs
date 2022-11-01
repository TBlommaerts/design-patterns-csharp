using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
		{
			/*
			 * We are using a complex third party video conversion framework to convert two video files to a new format and fix the audio.
			 * 
			 * TODO try to use the Facade design pattern to hide all of these complexities.
			 */
			String filename = "MPEG4-video.ogg";
			VideoFile file = new VideoFile(filename);
			DecompressionCodec sourceCodec = new CodecFactory().extract(file);
			CompressionCodec destinationCodec = new MPEG4CompressionCodec();

			byte[] buffer = BitrateReader.read(filename, sourceCodec);
			VideoFile result = BitrateReader.convert(filename, buffer, destinationCodec);
			result = new AudioMixer().Fix(result);
			result.Save();

			String filename2 = "Ogg-video.ogg";
			VideoFile file2 = new VideoFile(filename2);
			DecompressionCodec sourceCodec2 = new CodecFactory().extract(file2);
			CompressionCodec destinationCodec2 = new OggCompressionCodec();

			byte[] buffer2 = BitrateReader.read(filename2, sourceCodec2);
			VideoFile result2 = BitrateReader.convert(filename2, buffer2, destinationCodec2);
			result2 = new AudioMixer().Fix(result2);
			result2.Save();
		}
    }
}
