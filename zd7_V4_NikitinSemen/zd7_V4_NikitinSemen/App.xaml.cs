﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd7_V4_NikitinSemen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Page4());
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
