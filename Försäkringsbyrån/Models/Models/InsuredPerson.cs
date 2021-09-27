﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    /// <summary>
    /// Försäkrad.
    /// </summary>
   public class InsuredPerson
    {
        public int InsuredID { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual InsuranceTaker Taker { get; set; }
    }
}
