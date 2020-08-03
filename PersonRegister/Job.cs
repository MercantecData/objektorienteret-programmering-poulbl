using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegister
{
    public class Job
    {
        public string title;
        public string workplaceName;
        public int hours;
        //Min: 0.0f - Max 100.0f
        public float replaceability;

        public Job(string title, string workplaceName, int hours, float replaceability)
        {
            this.title = title;
            this.workplaceName = workplaceName;
            this.hours = hours;
            this.replaceability = Math.Clamp(replaceability, 0.0f, 100.0f);
        }
    }
}
