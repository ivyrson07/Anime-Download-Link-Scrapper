using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeScrapper.Models
{
    public class ScrapeResult
    {
        public string Message { get; set; }

        public int RecordCount { get; set; }

        public bool Success { get; set; }
    }
}
