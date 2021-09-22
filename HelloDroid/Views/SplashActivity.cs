﻿using System;
using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using Softeq.XToolkit.WhiteLabel;
using Hello.ViewModels;

namespace HelloDroid
{
    //[Activity(
    //MainLauncher = true,
    //NoHistory = true)]
    [Activity]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Entry point
            Dependencies.PageNavigationService
                .For<MainPageViewModel>()
                .Navigate();

            Finish();
        }
    }
}
