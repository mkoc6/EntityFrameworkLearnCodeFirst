﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLearnCodeFirst.Entity
{
    public class Musteriler
    {
        [Key]
        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSehir { get; set; }
        public string MusteriUnvan { get; set; }
        
    }
}
