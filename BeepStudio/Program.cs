using System.Media;
using BeepStudio.Enums;
using BeepStudio.Library;
using BeepStudio.Sequencer;

namespace BeepStudio
{
    internal static class Program
    {
        private static void Main()
        {
            TechnoTrack();
        }

        private static void TechnoTrack()
        {
            var bpm = 118;
            
            var seq0 = new Sequencer.Sequencer(bpm)
                    .AddTrack(new Track("----|--+-|----|----|----|--+-|----|----|----|--+-|----|----|----|--+-|----|----", DrumSet.HiHatClosed))
                    .AddTrack(new Track("+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---", DrumSet.KickDrum))
                    .AddTrack(new Track("--+-|----|----|----|----|----|----|----|----|----|----|----|----|----|----|----", new Sequence().AddSpeech("Hardcore")))
                    .AddTrack(new Track("----|----|----|----|--+-|----|----|----|----|----|----|----|----|----|----|----", new Sequence().AddSpeech("Console")))
                    .AddTrack(new Track("----|----|----|----|----|----|----|----|--+-|----|----|----|----|----|----|----", new Sequence().AddSpeech("Techno")))
                    .AddTrack(new Track("----|----|----|----|----|----|----|----|----|----|----|----|--+-|----|----|----", new Sequence().AddSpeech("Music")))
                    .AddTrack(new Track("--+-|----|----|----|----|----|----|----|--+-|----|----|----|----|----|----|----", new Sequence().AddSystemSound(SystemSounds.Beep)))
                ;
            
            seq0.Loop(1);
            
            var seq1 = new Sequencer.Sequencer(bpm)
                    .AddTrack(new Track("----|--+-|----|----|----|--+-|----|----|----|--+-|----|----|----|--+-|----|----", DrumSet.HiHatClosed))
                    .AddTrack(new Track("----|----|----|--+-|----|----|----|--+-|----|----|----|--+-|----|----|----|--+-", DrumSet.KickDrum))
                    .AddTrack(new Track("+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---|+---", new Sequence().AddNote(NoteFrequency.D1S, 160)))
                    .AddTrack(new Track("--+-|----|----|----|----|----|----|----|--+-|----|----|----|----|----|----|----", new Sequence().AddSpeech("Yesss")))
                    .AddTrack(new Track("----|----|----|----|-+--|----|----|----|----|----|----|----|-+--|----|----|----", new Sequence().AddSpeech("Oh, yeah")))
                    .AddTrack(new Track("----|----|----|----|----|----|----|----|+---|----|----|----|----|----|----|----", new Sequence().AddSystemSound(SystemSounds.Beep)))
                    .AddTrack(new Track("--+-|----|----|----|----|----|----|----|--+-|----|----|----|----|----|----|----", new Sequence().AddSystemSound(SystemSounds.Hand)))
                ;
            
            seq1.Loop(1);

            var seq2 = new Sequencer.Sequencer(bpm)
                    .AddTrack(new Track("----|--+-|----|----|----|--+-|----|----|----|--+-|----|----|----|--+-|----|----", DrumSet.HiHatClosed))
                    .AddTrack(new Track("----|----|----|--+-|----|----|----|--+-|----|----|----|--+-|----|----|----|--+-", DrumSet.KickDrum))
                    .AddTrack(new Track("+---|+---|+---|+---|----|----|----|----|----|----|----|----|----|----|----|----", new Sequence().AddNote(NoteFrequency.G1S, 160)))
                    .AddTrack(new Track("----|----|----|----|+---|+---|+---|+---|----|----|----|----|----|----|----|----", new Sequence().AddNote(NoteFrequency.F1S, 160)))
                    .AddTrack(new Track("----|----|----|----|----|----|----|----|+---|+---|+---|+---|+---|+---|+---|+---", new Sequence().AddNote(NoteFrequency.D1S, 160)))
                    .AddTrack(new Track("----|----|----|+---|----|----|----|----|----|----|----|----|----|----|----|----", new Sequence().AddSpeech("Yeeaah")))
                    .AddTrack(new Track("----|----|----|----|+---|+---|+-+-|+---|+---|----|----|----|----|----|----|----", new Sequence().AddSystemSound(SystemSounds.Beep)))
                    .AddTrack(new Track("----|----|----|----|--+-|--+-|----|--+-|----|----|----|----|----|----|----|----", new Sequence().AddSystemSound(SystemSounds.Hand)))
                ;
            
            seq2.Loop(1);
            
            var seq3 = new Sequencer.Sequencer(bpm)
                    .AddTrack(new Track("----|--+-|----|----|----|--+-|--+-|----", DrumSet.HiHatClosed))
                    .AddTrack(new Track("----|----|----|--+-|----|----|----|--+-", DrumSet.KickDrum))
                    .AddTrack(new Track("+---|+---|+---|+---|+---|+---|+---|+---", new Sequence().AddNote(NoteFrequency.D1S, 160)))
                ;

            seq3.Loop(1);
            
            var seq4 = new Sequencer.Sequencer(bpm);
            seq4
                .AddTrack(new Track("----|----|----|----|+---|----|----|----", new Sequence().AddNote(NoteFrequency.A1S, seq4.Duration.Whole)))
                .AddTrack(new Track("+---|----|----|----|----|----|----|----", new Sequence().AddNote(NoteFrequency.G1S, seq4.Duration.Whole)))
                .AddTrack(new Track("----|----|----|-+--|----|----|----|----", new Sequence().AddSpeech("How'd you like it?")))
                .AddTrack(new Track("----|----|----|----|+---|----|----|----", new Sequence().AddSystemSound(SystemSounds.Hand)))
                ;
            
            seq4.Loop(1);

            var seq5 = new Sequencer.Sequencer(bpm)
                    .AddTrack(new Track("----|---+|----|----|----|---+|----|----", DrumSet.QuadroSnareDrum))
                    .AddTrack(new Track("----|--+-|----|----|----|--+-|----|----", DrumSet.HiHatClosed))
                    .AddTrack(new Track("----|----|----|--+-|----|----|----|--+-", DrumSet.KickDrum))
                    .AddTrack(new Track("+---|+---|+---|+---|+---|+---|+---|+---", new Sequence().AddNote(NoteFrequency.D1S, 160)))
                    .AddTrack(new Track("----|+---|----|----|----|----|----|----", new Sequence().AddSpeech("That's")))
                    .AddTrack(new Track("----|----|----|----|+---|----|----|----", new Sequence().AddSpeech("Good")))
                    .AddTrack(new Track("----|----|----|----|----|----|----|-+--", new Sequence().AddSystemSound(SystemSounds.Beep)))
                ;
            
            var seq6 = new Sequencer.Sequencer(bpm)
                    .AddTrack(new Track("----|---+|----|----|----|---+|----|----", DrumSet.QuadroSnareDrum))
                    .AddTrack(new Track("----|--+-|----|----|----|--+-|----|----", DrumSet.HiHatClosed))
                    .AddTrack(new Track("----|----|----|--+-|----|----|----|--+-", DrumSet.KickDrum))
                    .AddTrack(new Track("----|----|----|----|+---|+---|+---|+---", new Sequence().AddNote(NoteFrequency.A1S, 160)))
                    .AddTrack(new Track("+---|+---|+---|+---|----|----|----|----", new Sequence().AddNote(NoteFrequency.G1S, 160)))
                    .AddTrack(new Track("-+--|----|----|----|----|-+--|----|----", new Sequence().AddSpeech("Ohohohoh")))
                    .AddTrack(new Track("----|----|----|----|----|----|-+--|----", new Sequence().AddSpeech("Yeeeaaah")))
                    .AddTrack(new Track("----|----|----|----|----|----|+-+-|+-+-", new Sequence().AddSystemSound(SystemSounds.Hand)))
                ;
            
            seq5.Loop(2);
            
            seq6.Loop(1);
            seq1.Loop(1);

            var seq7 = new Sequencer.Sequencer(bpm);
            seq7.AddTrack(new Track("----|----|----|----|+---|----|----|----", new Sequence().AddNote(NoteFrequency.A1S, seq7.Duration.Whole)))
                .AddTrack(new Track("+---|----|----|----|----|----|----|----", new Sequence().AddNote(NoteFrequency.G1S, seq7.Duration.Whole)))
                .AddTrack(new Track("----|----|----|-+--|----|----|----|----", new Sequence().AddSpeech("How'd you like it? ahahahaha loll")))
                ;
            
            seq7.Loop(1);

            var seq8 = new Sequencer.Sequencer(bpm);
            seq8.AddTrack(new Track("+---|----|----|----|----|----|----|----", new Sequence().AddNote(NoteFrequency.D1S, seq8.Duration.Whole * 2)));
            
            seq8.Loop(1);
        }
    }
}
