using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegister
{
    public class Job
    {
        private string title;
        private string workplaceName;
        private int hours;
        //Min: 0.0f - Max 100.0f
        private float replaceability;

        public Job(string title, string workplaceName, int hours, float replaceability)
        {
            this.title = title;
            this.workplaceName = workplaceName;
            this.hours = hours;
            this.replaceability = Math.Clamp(replaceability, 0.0f, 100.0f);
        }
    }
}
