﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuceMIS4200_1045_sp20.Models
{
    public class Orders
    {
        [Key]
        public int orderNum { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        public int customerID { get; set; }

        public virtual customer customer { get; set; }

    }
}