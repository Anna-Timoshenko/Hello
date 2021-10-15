using System;
using Foundation;
using Softeq.XToolkit.Bindings.iOS.Bindable;
using UIKit;
using Hello.Models;
using Softeq.XToolkit.Common.iOS.Extensions;

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

            PetIcon.BackgroundColor = ViewModel.Color.UIColorFromHex();
            PetIcon.Layer.CornerRadius = 25;
            PetName.Text = ViewModel.Name;
        }
    }
}