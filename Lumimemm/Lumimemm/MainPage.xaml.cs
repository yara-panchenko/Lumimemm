using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lumimemm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void on_Clicked(object sender, EventArgs e)
        {
            head.Opacity = 1;
            body1.Opacity = 1;
            body2.Opacity = 1;
            lbl.Text = "Lumimemm on";
        }

        private void off_Clicked(object sender, EventArgs e)
        {
            head.Opacity = 0;
            body1.Opacity = 0;
            body2.Opacity = 0;
            lbl.Text = "Lumimemm on kadunud";
        }
        Random rnd = new Random();
        private void rand_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "Juhuslik värv";
            head.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            body1.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            body2.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }



    }
}