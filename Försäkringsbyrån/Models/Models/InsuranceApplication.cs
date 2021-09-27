﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{/// <summary>
/// Ansökan! :)
/// </summary>
    public class InsuranceApplication
    {
        public int SerialNumber { get; set; } // Löpnummer 
        public InsuredPerson InsuredID { get; set; }
        public InsuranceType InsuranceTypeId { get; set; }
        public SignedInsurance InsuranceNumber { get; set; }
        public Employee AgentNo { get; set; }
        //public SalesMen AgentNumber { get; set; }
        public virtual InsuranceTaker Taker { get; set; }
    }
}
