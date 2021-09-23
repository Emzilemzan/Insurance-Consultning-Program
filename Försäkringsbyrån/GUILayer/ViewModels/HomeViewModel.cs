﻿using GUILayer.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUILayer.ViewModels
{
    /// <summary>
    /// Welcome page
    /// </summary>
    public class HomeViewModel : BaseViewModel
    {
        public static readonly HomeViewModel Instance = new HomeViewModel();

        public HomeBtn HomeButton { get; }

        private HomeViewModel()
        {
            HomeButton = new HomeBtn();
        }
        //public string Firstname=> _employee.Firstname;
    }
}
