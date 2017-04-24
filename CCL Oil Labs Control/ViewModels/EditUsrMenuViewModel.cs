﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCL_Oil_Labs_Control.Model;
using CCL_Oil_Labs_Control.CompositeCommands;
using Prism.Mvvm;
using Prism.Commands;
using System.Windows;
using System.Security;

namespace CCL_Oil_Labs_Control.ViewModels
{
    public class EditUsrMenuViewModel : BindableBase
    {
        private IList<string> _userNames;
        public IList<string> userNames
        {
            get { return _userNames = User.getuserNames(); }
            set { SetProperty(ref _userNames, value); }
        }
        private IGLobalNavigateCommand _globalNavigateCommand;
        public IGLobalNavigateCommand globalNavigateCommand
        {
            get { return _globalNavigateCommand; }
            set { SetProperty(ref _globalNavigateCommand, value); }
        }
        public EditUsrMenuViewModel(GlobalNavigateCommand globalNavigateCommand)
        {
            this.globalNavigateCommand = globalNavigateCommand;
        }

        private string selectedUserName { get; set; }

        private DelegateCommand<object[]> _selectedCommand;
        public DelegateCommand<object[]> selectedCommand =>
            _selectedCommand ?? (_selectedCommand = new DelegateCommand<object[]>(onItemSelected, (u) => true));

        private void onItemSelected(object[] selectedItems)
        {
            if (selectedItems != null && selectedItems.Count() > 0)
            {
                selectedUserName = selectedItems.FirstOrDefault() as string;
            }
        }

        private SecureString _oldPassword;
        public SecureString oldPassword
        {
            get { return _oldPassword; }
            set { SetProperty(ref _oldPassword, value); }
        }

        private SecureString _newPassword;
        public SecureString newPassword
        {
            get { return _newPassword; }
            set { SetProperty(ref _newPassword, value); }
        }

        private SecureString _confirmNewPassword;
        public SecureString confirmNewPassword
        {
            get { return _confirmNewPassword; }
            set { SetProperty(ref _confirmNewPassword, value); }
        }

        private DelegateCommand _saveCommand;
        public DelegateCommand saveCommand =>
            _saveCommand ?? (_saveCommand = new DelegateCommand(save,
                () => !string.IsNullOrWhiteSpace(selectedUserName) && oldPassword != null
            && oldPassword.Length > 0
            && newPassword != null && newPassword.Length > 0
            && confirmNewPassword != null && confirmNewPassword.Length > 0));

        private void save()
        {
            User editedUser = new User(selectedUserName, oldPassword);
            if (!editedUser.login())
                MessageBox.Show("Wrong Password");
            else
            {
                //TODO call User.editPass
                MessageBox.Show("Save Successful");
            }
        }
    }
}