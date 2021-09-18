namespace BeepStudio.Sequencer
{
    public class Track
    {
        public Track(string sequence, Sequence sound)
        {
            Sequence = sequence.Replace("|", "");
            Sound = sound;
        }

        public int Length => Sequence.Length;
        private string Sequence { get; }
        private Sequence Sound { get; }
        private char CurrentSymbol(int step) => Sequence[step % Sequence.Length];

        public void Play(int step)
        {
            var symbol = CurrentSymbol(step);
            if (symbol == '+') Sound.Play();
        }
    }
}
