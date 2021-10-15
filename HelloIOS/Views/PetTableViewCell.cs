using System;
using Foundation;
using Softeq.XToolkit.Bindings.iOS.Bindable;
using UIKit;
using Hello.Models;

namespace HelloIOS.Views
{
    public partial class PetTableViewCell : BindableTableViewCell<PetViewModel>
    {
        public static readonly NSString Key = new NSString("PetTableViewCell");
        public static readonly UINib Nib;

        static PetTableViewCell()
        {
            Nib = UINib.FromName("PetTableViewCell", NSBundle.MainBundle);
        }

        protected PetTableViewCell(IntPtr handle) : base(handle)
        {
        }

        public override void DoAttachBindings()
        {
            base.DoAttachBindings();
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            PetIcon.BackgroundColor = ToUIColor(ViewModel.Color);
            PetIcon.Layer.CornerRadius = 25;
            PetName.Text = ViewModel.Name;
        }

        private UIColor ToUIColor(string hexString)
        {
            hexString = hexString.Replace("#", "");

            if (hexString.Length == 3)
                hexString = hexString + hexString;

            if (hexString.Length != 6)
                throw new Exception("Invalid hex string");

            int red = Int32.Parse(hexString.Substring(0, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            int green = Int32.Parse(hexString.Substring(2, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            int blue = Int32.Parse(hexString.Substring(4, 2), System.Globalization.NumberStyles.AllowHexSpecifier);

            return UIColor.FromRGB(red, green, blue);
        }
    }
}
