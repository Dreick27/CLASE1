﻿using Practica1.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vista1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
