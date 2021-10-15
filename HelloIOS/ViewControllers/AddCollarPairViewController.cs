using System;
using System.Collections.Generic;
using Hello.Models;
using Hello.ViewModels;
using HelloIOS.Views;
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

            NavigationBarView.SetTitle(ViewModel.Title);
            NavigationBarView.SetButtonClose(ViewModel.NavigateCommandBack);

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