using System;
using System.Collections.Generic;
using Hello.Models;
using Hello.ViewModels;
using HelloIOS.Views;
using Softeq.XToolkit.Bindings;
using Softeq.XToolkit.Bindings.iOS.Bindable;
using Softeq.XToolkit.WhiteLabel.iOS;
using UIKit;

namespace HelloIOS.ViewControllers
{
    public partial class AddCollarPairViewController : ViewControllerBase<AddCollarPairViewModel>
    {
        public AddCollarPairViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationController.NavigationBar.Hidden = true;

            TitleBar.Text = ViewModel.Title;

            ButtonClose.SetTitle("Close", UIKit.UIControlState.Normal);
            ButtonClose.SetCommand(ViewModel.NavigateCommandBack);

            ButtonDone.SetTitle(ViewModel.TextForRightButton, UIKit.UIControlState.Normal);

            TextChoose.Text = ViewModel.TextChoose;

            ButtonAdd.SetTitle("Add New Pet", UIKit.UIControlState.Normal);

            TableViewAddPet.RegisterNibForCellReuse(PetTableViewCell.Nib, PetTableViewCell.Key);
            TableViewAddPet.Source = new CustomSource(TableViewAddPet, ViewModel.PetsAdded)
            {
                HeightForRow = 64f,
            };

            TextPetsWithCollars.Text = ViewModel.TextWitckCollars;

            TableViewPetsWithCollars.RegisterNibForCellReuse(PetTableViewCell.Nib, PetTableViewCell.Key);
            TableViewPetsWithCollars.Source = new CustomSource(TableViewAddPet, ViewModel.Pets)
            {
                HeightForRow = 64f,
            };

        }

        private class CustomSource : BindableTableViewSource<PetViewModel,
                PetTableViewCell>
        {
            public CustomSource(UITableView tableView, IEnumerable<PetViewModel> items)
                : base(tableView, items)
            {
            }
        }
    }
}