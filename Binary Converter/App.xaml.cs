﻿using Binary_Converter.Services;
using Binary_Converter.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Binary_Converter
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
