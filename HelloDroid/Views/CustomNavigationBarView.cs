using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Softeq.XToolkit.Bindings;
using System;
using System.Windows.Input;

namespace HelloDroid.Views
{
    [Register("HelloDroid.Views.CustomNavigationBarView")]
    public class CustomNavigationBarView : LinearLayout
    {
        private TextView _textTitle;
        private Button _buttonRight;
        private ImageButton _buttonClose;

        public CustomNavigationBarView(Context context) : base(context)
        {
            Init(context);
        }

        public CustomNavigationBarView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Init(context);
        }

        public CustomNavigationBarView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {
            Init(context);
        }

        public CustomNavigationBarView(IntPtr handle, JniHandleOwnership owner) : base(handle, owner)
        {
        }

        private void Init(Context context)
        {
            Inflate(context, Resource.Layout.view_navigation_bar, this);

            _textTitle = FindViewById<TextView>(Resource.Id.view_navigation_bar_textView_title);
            _textTitle.Visibility = ViewStates.Invisible;

            _buttonRight = FindViewById<Button>(Resource.Id.view_navigation_bar_button_done);
            _buttonRight.Visibility = ViewStates.Invisible;

            _buttonClose = FindViewById<ImageButton>(Resource.Id.view_navigation_bar_imageButton_close);
            _buttonClose.Visibility = ViewStates.Invisible;
        }

        public void SetTitle(string text)
        {
            _textTitle.Text = text;
            _textTitle.Visibility = ViewStates.Visible;
        }

        public void SetButtonRight(string label, ICommand command = null)
        {
            _buttonRight.Text = label;
            _buttonRight.Visibility = ViewStates.Visible;

            if (command != null)
            {
                _buttonRight.SetCommand(nameof(_buttonRight.Click), command);
            }
        }

        public void SetButtonClose(ICommand command = null)
        {
            _buttonClose.Visibility = ViewStates.Visible;

            if (command != null)
            {
                _buttonClose.SetCommand(nameof(_buttonClose.Click), command);
            }
        }
    }
}