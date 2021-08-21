using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homemade.Resource
{
    public class MessageResource
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Byte[] File { get; set; }
        public DateTime Date { get; set; }
    }
}
