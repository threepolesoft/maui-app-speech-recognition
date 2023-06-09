using SpeechRecognitionMauiApp.Helpers.Android;
using SpeechRecognitionMauiApp.Util;

namespace SpeechRecognitionMauiApp;

public partial class MainPage : ContentPage
{

    public MainPage()
	{
		InitializeComponent();

		Init();
	}

	public async void Init()
	{

        AppPermission appPermission=new AppPermission();

        var MicroPer = await appPermission.RequestPermissionMicrophone();

		if (MicroPer)
		{
            MicrosoftCognitiveService microsoftCognitiveService = new MicrosoftCognitiveService();

            await microsoftCognitiveService.InitSpeech(new Progress<String>(regTex =>
            {
				if (regTex != "")
				{
					RegText.Text = regTex;

                }
            }));
        }
	}

}

