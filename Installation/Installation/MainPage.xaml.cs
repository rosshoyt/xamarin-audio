using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;


// Cross platform Xamarin audio API using the SimpleAudioPlayer
// https://devblogs.microsoft.com/xamarin/adding-sound-xamarin-forms-app/
// and here: https://github.com/adrianstevens/Xamarin-Plugins/tree/master/SimpleAudioPlayer
namespace Installation
{   

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
      
        // TODO make async
        void OnButtonClicked(object sender, EventArgs args)
        {
            buttonSound.Play();
        }

        private AudioClip buttonSound = new AudioClip(filepath: "Installation.Audio.BtnClick.wav", loop: false);
    }
}
