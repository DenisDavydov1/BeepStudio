using System.Threading;

namespace BeepStudio.Lasting
{
    public class Pause : ILasting
    {
        public Pause(int duration)
        {
            Duration = duration;
        }
        
        public int Duration { get; }
        
        public void Play()
        {
            Thread.Sleep(Duration);
        }
    }
}
