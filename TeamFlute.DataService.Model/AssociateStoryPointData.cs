using System;
using System.Collections.Generic;
using System.Text;

namespace TeamFlute.DataService.Model
{
    public class AssociateStoryPointData
    {
        public Guid Id { get; set; }

        public string Associate { get; set; }

        public string StoryNumber { get; set; }

        public double Release { get; set; }

        public double StoryPoints { get; set; }
    }
}
