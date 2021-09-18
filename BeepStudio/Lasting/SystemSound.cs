namespace BeepStudio.Lasting
{
    public class SystemSound : ILasting
    {
        public SystemSound(System.Media.SystemSound sound)
        {
            Sound = sound;
        }
        
        public int Duration => 0;
        private System.Media.SystemSound Sound { get; }
        
        public void Play()
        {
            Sound.Play();
        }
    }
}
