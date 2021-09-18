using System;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;

namespace BeepStudio.Sequencer
{
    public static class Player
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern void BeepBeep(int frequency, int duration);

        public static void Beep(double frequency, double duration)
        {
            Beep(1000, frequency, duration);
        }
        
        public static void Beep(double amplitude, double frequency, double duration)
        {
            // https://inphamousdevelopment.wordpress.com/2012/05/07/console-beep-for-64-bit-windows/
            var amp = amplitude * Math.Pow(2, 15) / 1000 - 1;
            var deltaFt = 2 * Math.PI * frequency / 44100.0;

            var samples = (int) (441.0 * duration / 10.0);
            var bytes = samples * sizeof(int);
            int[] hdr = { 0X46464952, 36 + bytes, 0X45564157, 0X20746D66, 16, 0X20001, 44100, 176400, 0X100004, 0X61746164, bytes };

            using (var ms = new MemoryStream(44 + bytes))
            {
                using (var bw = new BinaryWriter(ms))
                {
                    foreach (var t in hdr)
                        bw.Write(t);
                    for (var t = 0; t < samples; t++)
                    {
                        var sample = System.Convert.ToInt16(amp * Math.Sin(deltaFt * t));
                        bw.Write(sample);
                        bw.Write(sample);
                    }
                    bw.Flush();
                    ms.Seek(0, SeekOrigin.Begin);
                    using (var sp = new SoundPlayer(ms))
                    {
                        sp.PlaySync();
                    }
                }
            }
        }
    }
}
