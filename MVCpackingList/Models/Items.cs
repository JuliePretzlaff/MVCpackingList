using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCpackingList.Models
{
    public class Items
    {

        [Key]
        public int ItemID { get; set; }

        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public bool IsCarryOn { get; set; }
    }
}