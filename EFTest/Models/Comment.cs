﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public User User { get; set; }
        public News News { get; set; }
        public string Text { get; set; }
        public string PublicationTime { get; set; }
    }
}
