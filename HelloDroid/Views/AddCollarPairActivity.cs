﻿using System;
using Android.App;
using Android.OS;
using Hello.ViewModels;
using Softeq.XToolkit.WhiteLabel.Droid;

namespace HelloDroid.Views
{
    [Activity(
    MainLauncher = true,
    NoHistory = true)]
    public class AddCollarPairActivity : ActivityBase<AddCollarPairViewModel>
    {
        public AddCollarPairActivity()
        {
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_add_collar_pair);
        }
    }
}