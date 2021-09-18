namespace BeepStudio.Sequencer
{
    public class Duration
    {
        public Duration(int whole)
        {
            Whole = whole;
        }
        
        public int Whole { get; }
        public int Half => Whole / 2;
        public int Quarter => Whole / 4;
        public int Eighth => Whole / 8;
        public int Sixteenth => Whole / 16;
    }
}
