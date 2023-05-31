using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{

    public partial class MRoom
    {
        public int ID { get; set; }
        public Categories Category { get; set; }
        public double Day_Price { get; set; }
        public Nullable<int> Status_FK { get; set; }
        public DateTime? DateTo { get; set; }
        [ForeignKey("Status_FK")]
        public virtual Status Status { get; set; }

        public override string ToString()
        {
            return ID + " " + Category + " " + Day_Price + " " + Status.State + " " + DateTo;
        }
    }
}
