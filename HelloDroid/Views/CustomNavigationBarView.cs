using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Softeq.XToolkit.Bindings;
using System.Windows.Input;

namespace HelloDroid.Views
{
    [Register("HelloDroid.Views.CustomNavigationBarView")]
    public class CustomNavigationBarView : FrameLayout
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

        public void SetButtonRight(string label, ICommand command)
        {
            _buttonRight.Text = label;
            _buttonRight.Visibility = ViewStates.Visible;

            _buttonRight.SetCommand(nameof(_buttonRight.Click), command);
        }

        public void SetButtonClose(ICommand command)
        {
            _buttonClose.Visibility = ViewStates.Visible;

            _buttonClose.SetCommand(nameof(_buttonClose.Click), command);
        }
    }
}