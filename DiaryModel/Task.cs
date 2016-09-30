using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiaryModel.Enums;

namespace DiaryModel
{
    public class Task:Item
    {
        public TaskState State { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
