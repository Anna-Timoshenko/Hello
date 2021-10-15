﻿using System.Collections.Specialized;
using System.Windows.Input;
using CoreAnimation;
using Foundation;
using UIKit;

namespace HelloIOS
{
    public class LinkerPleaseInclude
    {
        public void Include(UIButton uiButton)
        {
            uiButton.TouchUpInside += (s, e) =>
                uiButton.SetTitle(uiButton.Title(UIControlState.Normal), UIControlState.Normal);
            uiButton.Enabled = true;
        }

        public void Include(UIBarButtonItem barButton)
        {
            barButton.Clicked += (s, e) =>
                barButton.Title = barButton.Title + "";
        }

        public void Include(UITextField textField)
        {
            textField.Text = textField.Text + "";
            textField.EditingChanged += (sender, args) => { textField.Text = ""; };
            textField.Started += (sender, args) => { textField.Text = ""; };
            textField.Ended += (sender, args) => { textField.Text = ""; };
            textField.EditingDidBegin += (sender, args) => { textField.Text = ""; };
        }

        public void Include(UITextView textView)
        {
            textView.Text = textView.Text + "";
            textView.Changed += (sender, args) => { textView.Text = ""; };
            textView.Started += (sender, args) => { textView.Text = ""; };
            textView.Ended += (sender, args) => { textView.Text = ""; };
        }

        public void Include(UIScrollView scrollView)
        {
            scrollView.DraggingStarted += (sender, e) => { };
        }

        public void Include(UILabel label)
        {
            label.Text = label.Text + "";
        }

        public void Include(UIImageView imageView)
        {
            imageView.Image = new UIImage(imageView.Image.CGImage);
        }

        public void Include(UIDatePicker date)
        {
            date.Date = date.Date.AddSeconds(1);
            date.ValueChanged += (sender, args) => { date.Date = new NSDate(); };
        }

        public void Include(UISlider slider)
        {
            slider.Value = slider.Value + 1;
            slider.ValueChanged += (sender, args) => { slider.Value = 1; };
        }

        public void Include(UISwitch sw)
        {
            sw.On = !sw.On;
            sw.ValueChanged += (sender, args) => { sw.On = false; };
        }

        public void Include(CATransition transition)
        {
            transition.AnimationStopped += (sender, args) => { transition.Duration = 0.5; };
        }

        public void Include(INotifyCollectionChanged changed)
        {
            changed.CollectionChanged += (s, e) =>
            {
                var test = $"{e.Action}{e.NewItems}{e.NewStartingIndex}{e.OldItems}{e.OldStartingIndex}";
            };
        }

        public void Include(ICommand command)
        {
            command.CanExecuteChanged += (s, e) =>
            {
                if (command.CanExecute(null))
                {
                    command.Execute(null);
                }
            };
        }

        public void Include(UITabBarController controller)
        {
            controller.ViewControllerSelected += (sender, e) =>
            {
                var test = $"{sender}, {e.ViewController}, {e}";
            };
            controller.SelectedIndex = 1;
        }
    }
}