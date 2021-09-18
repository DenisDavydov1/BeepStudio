﻿using System;
using BeepStudio.Enums;
using BeepStudio.Sequencer;

namespace BeepStudio.Lasting
{
    public class Note : ILasting
    {
        public Note(NoteFrequency noteFrequency , int duration)
        {
            Frequency = (int) noteFrequency;
            Duration = duration;
        }

        public Note(int frequency, int duration)
        {
            if (frequency is < 37 or > 32767)
                throw new ArgumentException($"Invalid frequency: '{frequency}'. Should be between 37 Hz and 32767 Hz.");
            
            Frequency = frequency;
            Duration = duration;
        }
        
        public int Frequency { get; }
        public int Duration { get; }

        public void Play()
        {
            Player.Beep(Frequency, Duration);
        }

        // private static readonly IDictionary<string, double> NoteFrequency = new Dictionary<string, double>
        // {
        //     // From 37 Hz to 32767 Hz available
        //
        //     // 1st octave
        //     ["c1"] = 37,
        //     ["c1#"] = 37,
        //     ["d1"] = 37,
        //     ["d1#"] = 38.89,
        //     ["e1"] = 41.20,
        //     ["f1"] = 43.65,
        //     ["f1#"] = 46.25,
        //     ["g1"] = 49.00,
        //     ["g1#"] = 51.91,
        //     ["a1"] = 55.00,
        //     ["a1#"] = 58.27,
        //     ["b1"] = 61.74,
        //     
        //     // 2nd octave
        //     ["c2"] = 65.41,
        //     ["c2#"] = 69.30,
        //     ["d2"] = 73.42,
        //     ["d2#"] = 77.78,
        //     ["e2"] = 82.41,
        //     ["f2"] = 87.31,
        //     ["f2#"] = 92.50,
        //     ["g2"] = 98.00,
        //     ["g2#"] = 103.83,
        //     ["a2"] = 110.00,
        //     ["a2#"] = 116.54,
        //     ["b2"] = 123.47,
        //     
        //     // 3rd octave
        //     ["c3"] = 130.81,
        //     ["c3#"] = 138.59,
        //     ["d3"] = 146.83,
        //     ["d3#"] = 155.56,
        //     ["e3"] = 164.81,
        //     ["f3"] = 174.61,
        //     ["f3#"] = 185.00,
        //     ["g3"] = 196.00,
        //     ["g3#"] = 207.65,
        //     ["a3"] = 220.00,
        //     ["a3#"] = 233.08,
        //     ["b3"] = 246.94,
        //     
        //     // 4th octave
        //     ["c4"] = 261.63,
        //     ["c4#"] = 277.18,
        //     ["d4"] = 293.66,
        //     ["d4#"] = 311.13,
        //     ["e4"] = 329.63,
        //     ["f4"] = 349.23,
        //     ["f4#"] = 369.99,
        //     ["g4"] = 392.00,
        //     ["g4#"] = 415.30,
        //     ["a4"] = 440.00,
        //     ["a4#"] = 466.16,
        //     ["b4"] = 493.88,
        //     
        //     // 5th octave
        //     ["c5"] = 523.25,
        //     ["c5#"] = 554.37,
        //     ["d5"] = 587.33,
        //     ["d5#"] = 622.25,
        //     ["e5"] = 659.25,
        //     ["f5"] = 698.46,
        //     ["f5#"] = 739.99,
        //     ["g5"] = 783.99,
        //     ["g5#"] = 830.61,
        //     ["a5"] = 880.00,
        //     ["a5#"] = 932.33,
        //     ["b5"] = 987.77,
        //     
        //     // 6th octave
        //     ["c6"] = 1046.50,
        //     ["c6#"] = 1108.73,
        //     ["d6"] = 1174.66,
        //     ["d6#"] = 1244.51,
        //     ["e6"] = 1318.51,
        //     ["f6"] = 1396.91,
        //     ["f6#"] = 1479.98,
        //     ["g6"] = 1567.98,
        //     ["g6#"] = 1661.22,
        //     ["a6"] = 1760.00,
        //     ["a6#"] = 1864.66,
        //     ["b6"] = 1975.53,
        //     
        //     // 7th octave
        //     ["c7"] = 2093.00,
        //     ["c7#"] = 2217.46,
        //     ["d7"] = 2349.32,
        //     ["d7#"] = 2489.02,
        //     ["e7"] = 2637.02,
        //     ["f7"] = 2793.83,
        //     ["f7#"] = 2959.96,
        //     ["g7"] = 3135.96,
        //     ["g7#"] = 3322.44,
        //     ["a7"] = 3520.00,
        //     ["a7#"] = 3729.31,
        //     ["b7"] = 3951.07,
        //     
        //     // 8th octave
        //     ["c8"] = 4186.01,
        //     ["c8#"] = 4434.92,
        //     ["d8"] = 4698.63,
        //     ["d8#"] = 4978.03,
        //     ["e8"] = 5274.04,
        //     ["f8"] = 5587.65,
        //     ["f8#"] = 5919.91,
        //     ["g8"] = 6271.93,
        //     ["g8#"] = 6644.88,
        //     ["a8"] = 7040.00,
        //     ["a8#"] = 7458.62,
        //     ["b8"] = 7902.13,
        // };
    }
}
