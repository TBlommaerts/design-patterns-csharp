using System;

namespace Facade
{
    public class VideoFile
    {
		private String Filename;

		public VideoFile(String filename)
		{
			this.Filename = filename;
		}

		public String GetFilename()
		{
			return Filename;
		}

		public void Save()
		{
			Console.WriteLine("Storing file to destination: " + Filename + ".");
		}
	}
}
