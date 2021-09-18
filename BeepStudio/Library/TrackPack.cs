using BeepStudio.Sequencer;
using NF = BeepStudio.Enums.NoteFrequency;

namespace BeepStudio.Library
{
    public static class TrackPack
    {
        public static Sequence WeAreNumberOne(int wholeDuration)
        {
            var dur = new Duration(wholeDuration);

            var seq = new Sequence()
                .AddNote(NF.F4, dur.Quarter)
                .AddPause(dur.Eighth)
                .AddNote(NF.C5, dur.Eighth)
                .AddNote(NF.B4, dur.Sixteenth)
                .AddNote(NF.C5, dur.Sixteenth)
                .AddNote(NF.B4, dur.Sixteenth)
                .AddNote(NF.C5, dur.Sixteenth)
                .AddNote(NF.G4S, dur.Quarter)
                .AddNote(NF.F4, dur.Quarter)
                .AddPause(dur.Quarter)

                .AddNote(NF.F4, dur.Eighth)
                .AddNote(NF.G4S, dur.Sixteenth)
                .AddNote(NF.C5, dur.Sixteenth)
                .AddNote(NF.C5S, dur.Quarter)
                .AddNote(NF.G4S, dur.Quarter)
                .AddNote(NF.C5S, dur.Quarter)
                .AddNote(NF.D5S, dur.Quarter)
                .AddNote(NF.C5, dur.Sixteenth)
                .AddNote(NF.C5S, dur.Sixteenth)
                .AddNote(NF.C5, dur.Sixteenth)
                .AddNote(NF.C5S, dur.Sixteenth)
                .AddNote(NF.C5, dur.Quarter)
                .AddPause(dur.Half);

            return seq;
        }

        public static Sequence MaryHadALittleLamb(int wholeDuration)
        {
            var dur = new Duration(wholeDuration);

            var seq = new Sequence()
                .AddNote(NF.B3, dur.Quarter)
                .AddNote(NF.A3, dur.Quarter)
                .AddNote(NF.G3, dur.Quarter)
                .AddNote(NF.A3, dur.Quarter)
                .AddNote(NF.B3, dur.Quarter)
                .AddNote(NF.B3, dur.Quarter)
                .AddNote(NF.B3, dur.Half)
                .AddNote(NF.A3, dur.Quarter)
                .AddNote(NF.A3, dur.Quarter)
                .AddNote(NF.A3, dur.Half)
                .AddNote(NF.B3, dur.Quarter)
                .AddNote(NF.D4, dur.Quarter)
                .AddNote(NF.D4, dur.Half);

            return seq;
        }
        
        public static Sequence FeelGoodInc(int wholeDuration)
        {
            // https://pianokafe.com/upload/iblock/89e/b_pianokafe.com_gorillaz_feel_good_inc.jpg
            var dur = new Duration(wholeDuration);

            var seq = new Sequence()
                .AddNote(NF.E2, dur.Eighth)
                .AddPause(dur.Eighth)
                .AddPause(dur.Eighth)
                .AddNote(NF.E2, dur.Eighth)
                .AddNote(NF.F2, dur.Eighth)
                .AddNote(NF.G2, dur.Eighth)
                .AddPause(dur.Eighth)
                .AddNote(NF.C3, dur.Eighth)
                .AddPause(dur.Sixteenth)
                .AddNote(NF.B2, dur.Quarter)
                .AddPause(dur.Half)

                .AddNote(NF.A2, dur.Eighth)
                .AddPause(dur.Eighth)
                .AddPause(dur.Eighth)
                .AddNote(NF.A2, dur.Eighth)
                .AddNote(NF.C3, dur.Eighth)
                .AddNote(NF.B2, dur.Eighth)
                .AddPause(dur.Eighth)
                .AddNote(NF.G2, dur.Eighth)
                .AddPause(dur.Sixteenth)
                .AddNote(NF.E2, dur.Quarter)
                .AddPause(dur.Half);

            return seq;
        }
    }
}
