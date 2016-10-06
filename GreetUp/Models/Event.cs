using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GreetUp.Models
{
    public class Event
    {

        [Key]

        public int ID { get; set; }
        [Display(Name ="Event Title")]
        public string EventTitle { get; set; }
        public string Details { get; set; }
        [Display(Name ="Event Date")]
        public DateTime EventDate { get; set; }
        [Display(Name ="Number of Guests")]
        public int NumOfRSVP { get; set; }


        [ForeignKey("EventType")]
        public int EventTypeID { get; set; }
        public virtual EventType EventType { get; set; }

    }

  
}