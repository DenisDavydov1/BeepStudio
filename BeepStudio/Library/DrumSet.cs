using BeepStudio.Enums;
using BeepStudio.Sequencer;

namespace BeepStudio.Library
{
    public static class DrumSet
    {
        public static Sequence KickDrum => new Sequence()
            .AddNote(60, 50);
        
        public static Sequence SnareDrumHigh => new Sequence()
            .AddNote(700, 5);
        
        public static Sequence SnareDrum => new Sequence()
            .AddNote(400, 5);
        
        public static Sequence DoubleSnareDrum => new Sequence()
            .AddNote(400, 5)
            .AddPause(10)
            .AddNote(800, 5);
        
        public static Sequence QuadroSnareDrum => new Sequence()
            .AddNote(1500, 2).AddPause(7)
            .AddNote(1500, 2).AddPause(7);
        
        public static Sequence HiHatClosed => new Sequence()
            .AddNote(3000, 5);
        
        public static Sequence Bass => new Sequence()
            .AddNote(NoteFrequency.D1S, 160);
    }
}
