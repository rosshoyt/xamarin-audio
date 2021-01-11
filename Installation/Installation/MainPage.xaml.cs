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

// Simple sound implementation based on the approach described here:
// https://devblogs.microsoft.com/xamarin/adding-sound-xamarin-forms-app/
namespace Installation
{   
    public enum SoundType
    {
        ButtonClickTest,
        count
    }

    public partial class MainPage : ContentPage
    {
        ISimpleAudioPlayer[] players = new ISimpleAudioPlayer[(int)SoundType.count];

        public MainPage()
        {
            InitializeComponent();
            SetupSounds();
        }
        void SetupSounds()
        {
            for (int i = 0; i < (int)SoundType.count; i++)
            {
                players[i] = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                players[i].Loop = false;
            }
            LoadSounds();
        }

        void LoadSounds()
        {
            // TODO replace hardcoded Solution and Folder names
            players[(int)SoundType.ButtonClickTest].Load(GetStreamFromFile("Installation.Audio.BtnClick.wav"));
        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream(filename);

            return stream;
        }

        // TODO - make async?
        void OnButtonClicked(object sender, EventArgs args)
        {
            players[0].Play();
        }
    }
}
