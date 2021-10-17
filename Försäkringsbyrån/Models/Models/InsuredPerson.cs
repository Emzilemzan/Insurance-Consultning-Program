﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    /// <summary>
    /// Försäkrad.
    /// </summary>
    /// 
    [Table("Försäkradperson", Schema = "dbo")]
    public class InsuredPerson
    {
        [Key]
        public int InsuredId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PersonType { get; set; }
        public virtual Person PersonTaker { get; set; }
        public virtual Company CompanyTaker { get; set; }

    }
}
