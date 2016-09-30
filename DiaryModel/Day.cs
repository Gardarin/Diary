using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryModel
{
    public class Day
    {
        public Int32 Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
