using System.Collections.Generic;
using BeepStudio.Enums;
using BeepStudio.Lasting;

namespace BeepStudio.Sequencer
{
    public class Sequence : List<ILasting>
    {
        public Sequence AddNote(NoteFrequency noteFrequency, int duration)
        {
            Add(new Note(noteFrequency, duration));
            return this;
        }
        
        public Sequence AddNote(int frequency, int duration)
        {
            Add(new Note(frequency, duration));
            return this;
        }
        
        public Sequence AddPause(int duration)
        {
            Add(new Pause(duration));
            return this;
        }

        public Sequence AddSpeech(string text, bool male = true)
        {
            Add(new Speech(text, male));
            return this;
        }

        public Sequence AddSystemSound(System.Media.SystemSound sound)
        {
            Add(new SystemSound(sound));
            return this;
        }
        
        public Sequence AddSequence(Sequence sequence)
        {
            AddRange(sequence);
            return this;
        }

        public void Play()
        {
            foreach (var item in this)
                item.Play();
        }
    }
}
