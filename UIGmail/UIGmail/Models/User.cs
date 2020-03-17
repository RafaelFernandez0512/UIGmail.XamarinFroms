using System;
using System.Collections.Generic;
using System.Text;

namespace UIGmail.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public int Color { get; set; }
        public DateTime DateTime { get; set; }
        public string TimeNow { get=> $"{DateTime.Now.ToString("HH:mm:ss")}";}
        public Message Message { get; set; }
        
    }
}
