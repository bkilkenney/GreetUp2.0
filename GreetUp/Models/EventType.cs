using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreetUp.Models
{
    public class EventType
    {

        public int ID { get; set; }
        [Display(Name = "Event Type")]
        public string EventTitle { get; set; }
        public virtual ICollection<Event> Events { get; set; }

    }
}