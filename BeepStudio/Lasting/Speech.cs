using System.Speech.Synthesis;

namespace BeepStudio.Lasting
{
    public class Speech : ILasting
    {
        public Speech(string text, bool male = true)
        {
            Text = text;
            Synthesizer = new SpeechSynthesizer();
            Synthesizer.SetOutputToDefaultAudioDevice();
            Synthesizer.SelectVoice(male
                ? "Microsoft David Desktop"
                : "Microsoft Zira Desktop");
        }

        public int Duration => 0;
        private string Text { get; }
        private SpeechSynthesizer Synthesizer { get; }
        
        public void Play()
        {
            Synthesizer.Speak(Text);
        }
    }
}
