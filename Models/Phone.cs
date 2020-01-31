using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PhoneAppliation.Models;

namespace PhoneApplication.Models
{
    public class Phone
    {

        public Phone()
        {
            PhoneName = "";
            DateReleased = DateTime.Now;
        }

        [ForeignKey("Manufacturer")]
        public int ManufacturerID { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        public int MSRP { get; set; }
        public int ScreenSize { get; set; }
        [Key]
        public int PhoneID { get; set; }
        public string PhoneName { get; set; }
        public DateTime DateReleased { get; set; }



    }
}