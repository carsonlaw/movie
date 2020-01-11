using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Movie
{
    public class MoviePlayer
    {
        public string Name { get; set; }
        public string From { get; set; }
        public string Server { get; set; }
        public string Note { get; set; }
        public string Url { get; set; }
    }
}
