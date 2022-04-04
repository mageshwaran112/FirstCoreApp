using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCoreModelApi.Common
{
    public class Books
    {
        public Int32 Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public Int32? Rate { get; set; }
        public string General { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAddded { get; set; }

    }
}
