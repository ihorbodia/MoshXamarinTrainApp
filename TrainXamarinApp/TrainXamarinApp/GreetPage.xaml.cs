﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;
        }
    }
}