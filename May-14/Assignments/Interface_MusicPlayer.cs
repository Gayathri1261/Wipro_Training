using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    using System;

    public interface IMusicPlayer
    {
        void Play(string song);
        void Pause();
        void Stop();
    }
    public class SpotifyPlayer : IMusicPlayer
    {
        public void Play(string song)
        {
            Console.WriteLine($"Playing {song} on Spotify");
        }

        public void Pause()
        {
            Console.WriteLine("Spotify playback paused");
        }

        public void Stop()
        {
            Console.WriteLine("Spotify playback stopped");
        }
    }
    public class AppleMusicPlayer : IMusicPlayer
    {
        public void Play(string song)
        {
            Console.WriteLine($"Playing {song} on Apple Music");
        }
        public void Pause()
        {
            Console.WriteLine("Apple Music playback paused");
        }
        public void Stop()
        {
            Console.WriteLine("Apple Music playback stopped");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            IMusicPlayer spotify = new SpotifyPlayer();
            spotify.Play("Shape of You");
            spotify.Pause();
            spotify.Stop();

            Console.WriteLine();
            IMusicPlayer appleMusic = new AppleMusicPlayer();
            appleMusic.Play("Blinding Lights");
            appleMusic.Pause();
            appleMusic.Stop();
        }
    }
}
