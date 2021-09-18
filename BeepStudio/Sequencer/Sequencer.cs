using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BeepStudio.Sequencer
{
    public class Sequencer
    {
        public Sequencer(int bpm)
        {
            Bpm = bpm;
            Duration = new Duration(60 * 1000 * 4 / Bpm);
        }

        public Duration Duration { get; set; }
        private int Bpm { get; }
        private List<Track> Tracks = new();
        private int _trackLength;

        public Sequencer AddTrack(Track track)
        {
            if (_trackLength == 0)
                _trackLength = track.Length;
            else if (_trackLength != track.Length)
                throw new ArgumentException(nameof(track));
            
            Tracks.Add(track);
            return this;
        }

        public void Play()
        {
            for (var i = 0; i < _trackLength; ++i)
            {
                var actions = Tracks.Select(t => new Action<int>(t.Play));
                
                 foreach (var action in actions)
                     Task.Run(() => action(i));

                 Thread.Sleep(Duration.Sixteenth);
            }
        }

        public void Loop(int repeats)
        {
            for (var i = 0; i < repeats; ++i)
                Play();
        }
    }
}
