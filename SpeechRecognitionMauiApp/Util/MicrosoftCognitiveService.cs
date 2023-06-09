using Microsoft.CognitiveServices.Speech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechRecognitionMauiApp.Util
{
    public class MicrosoftCognitiveService
    {
        public async Task InitSpeech(IProgress<string> RegText)
        {
            var config = SpeechConfig.FromSubscription("08cbff7df99a4f13a72a645b1ee53654", "eastasia");

            var recon = new SpeechRecognizer(config);

            recon.Recognized += (s, e) =>
            {
                if (e.Result.Reason == ResultReason.RecognizedSpeech)
                {
                    RegText.Report(e.Result.Text);
                }
            };

            await recon.StartContinuousRecognitionAsync().ConfigureAwait(false);

            //await recon.StopContinuousRecognitionAsync().ConfigureAwait(false);

        }
    }
}
