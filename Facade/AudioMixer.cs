using System;

namespace Facade
{
    public class AudioMixer
    {
        public VideoFile Fix(VideoFile input)
        {
            Console.WriteLine("Fixing audio in file: " + input.GetFilename() + ".");
            return input;
        }
    }
}
