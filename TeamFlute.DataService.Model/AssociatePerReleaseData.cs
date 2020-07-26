using System;
using System.Collections.Generic;
using System.Text;

namespace TeamFlute.DataService.Model
{
    public class AssociatePerReleaseData
    {
        public Guid Id { get; set; }

        public string Associate { get; set; }

        public double Release { get; set; }

        public double TotalStoryPoints { get; set; }
    }
}
