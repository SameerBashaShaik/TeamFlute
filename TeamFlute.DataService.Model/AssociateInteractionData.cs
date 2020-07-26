using System;
using System.Collections.Generic;
using System.Text;

namespace TeamFlute.DataService.Model
{
    public class AssociateInteractionData
    {
        public Guid Id { get; set; }

        public string Associate { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Notes { get; set; }
    }
}
