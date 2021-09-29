﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
   public class PersonInsurance : InsuranceType
    {
        public int PFId { get; set; }
        public DateTime DeliveryDate { get; set; }
   
        
    }
    public enum PersonInsuranceType
    {
        SOB,
        SOV,
        LIV
    }
}
