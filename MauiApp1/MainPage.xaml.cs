using Microsoft.Maui.Controls;
using System;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int clickCount = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnCounterClicked(object sender, EventArgs e)
        {
            clickCount++;
            CounterLabel.Text = $"Clicked {clickCount} times";
        }

        void OnSayHelloClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            if (!string.IsNullOrWhiteSpace(name))
            {
                GreetingLabel.Text = $"Hello, {name}!";
            }
        }
    }
}