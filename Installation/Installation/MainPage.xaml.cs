using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Installation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // TODO - make async?
        void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = sender as Button;
            button.Text = "Button Pressed!"; 
        }
    }
}
