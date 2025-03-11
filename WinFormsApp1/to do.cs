using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ToDo : IComparable<ToDo>
    {
        public int ID { get; set; } = 0;
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }

        public int CompareTo(ToDo? other)
        {
            if (DueDate < other.DueDate) return -1;
            else if (DueDate == other.DueDate) return 0;
            else return 1;
        }

        public override string ToString()
        {
            if (IsDone) {
                return "[X] " + ID.ToString() + " - " + DueDate.ToString("dddd, dd MMMM yyyy") + " - " + TaskDescription;
            }
            else
            {
                return ID.ToString() + " - " + DueDate.ToString("dddd, dd MMMM yyyy") + " - " + TaskDescription;
            }
        }


        //public ToDo(string description, DateTime Date, bool doneState)
        //{

        //}
    }
    //objectCounter++
    //    ID= ObjectCounter;
    //    TaskDescription = DescriptionAttribute;
    //    DueDate = DateTime;
    //    isdone = doneState;

}
