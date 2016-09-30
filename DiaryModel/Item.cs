using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryModel
{
    public class Item
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CompletdeDate { get; set; }
    }
}
