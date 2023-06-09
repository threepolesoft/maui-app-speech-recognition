using SpeechRecognitionMauiApp.Helpers.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechRecognitionMauiApp.Helpers.Android
{
    public class AppPermission
    {
        public async Task<bool> RequestPermissionMicrophone()
        {
            var status = await Permissions.RequestAsync<Permissions.Microphone>();

            return status == PermissionStatus.Granted;
        }
    }
}
