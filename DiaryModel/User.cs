using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryModel
{
    public class User
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Day> Days { get; set; }
    }
}
