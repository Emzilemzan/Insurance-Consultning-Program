﻿using GUILayer.Commands;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GUILayer.ViewModels.EmployeeManagementViewModels
{
    public class ManageUserAccessViewModel: BaseViewModel
    {
        public static readonly ManageUserAccessViewModel Instance = new ManageUserAccessViewModel();

        public ManageUserAccessViewModel()
        {

        }

        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        private string _lastname;
        public string Lastname
        {
            get => _lastname;
            set
            {
                _lastname = value;
                OnPropertyChanged("Lastname");
            }
        }

        private string _firstname;
        public string Firstname
        {
            get => _firstname;
            set
            {
                _firstname = value;
                OnPropertyChanged("Firstname");
            }
        }

        #region bools for access
        private bool _search;
        public bool Search
        {
            get => _search;
            set
            {
                _search = value;
                OnPropertyChanged("Search");
            }
        }

        private bool _sap;
        public bool StatisticsAndProspects
        {
            get => _sap;
            set
            {
                _sap = value;
                OnPropertyChanged("StatisticsAndProspects");
            }
        }

        private bool _employeeManagement;
        public bool EmployeeManagement
        {
            get => _employeeManagement;
            set
            {
                _employeeManagement = value;
                OnPropertyChanged("EmployeeManagement");
            }
        }

        private bool _insurances;
        public bool Insurances
        {
            get => _insurances;
            set
            {
                _insurances = value;
                OnPropertyChanged("Insurances");
            }
        }

        private bool _basicData;
        public bool BasicData
        {
            get => _basicData;
            set
            {
                _basicData = value;
                OnPropertyChanged("BasicData");
            }
        }

        private bool _commission;
        public bool Commission
        {
            get => _commission;
            set
            {
                _commission = value;
                OnPropertyChanged("BasicData");
            }
        }
        #endregion
        private ICommand _addUserBtn;
        public ICommand AddUserBtn
        {
            get => _addUserBtn ?? (_addUserBtn = new RelayCommand(x => { InsertUser(); CanCommand(); }));
        }

        public bool CanCommand()
        {
            return !string.IsNullOrWhiteSpace(Instance.Username) && !string.IsNullOrWhiteSpace(Instance.Password);
        }


        private void InsertUser()
        {
            if (Instance._username != null)
            {
                UserAccess a = new UserAccess()
                {
                    Username = Instance.Username,
                    Password = Instance.Password,
                    Search = Instance.Search,
                    StatisticsAndProspects = Instance.StatisticsAndProspects,
                    Insurances = Instance.Insurances,
                    EmployeeManagement = Instance.EmployeeManagement,
                    Commission = Instance.Commission,
                    BasicData = Instance.BasicData
                };
                Context.UAController.CheckExistingUser(Instance._username, a);
                MainViewModel.Instance.ToolsVisibility = Visibility.Collapsed;
                MainViewModel.Instance.CurrentTool = "";
                //HandleEmployeeViewModel.Instance.UpdateSM();
                //MainViewModel.Instance.SelectedViewModel = HandleEmployeeViewModel.Instance;
            }
            else
            {
                MessageBox.Show("Anställningsnummer får inte lämnas tomt");
            }
        }

    }

}
