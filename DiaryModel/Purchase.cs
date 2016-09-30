using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiaryModel.Enums;

namespace DiaryModel
{
    public class Purchase:Item
    {
        public String PurchaseType { get; set; }
        public Int32 Budget { get; set; }
        public Int32 FirstPrice { get; set; }
        public Int32 FinalPrice { get; set; }
        public PurchasePriority Priority { get; set; }
        public PurchaseState State { get; set; }
    }
}
