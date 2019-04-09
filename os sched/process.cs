using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace os_sched
{
    public class process
    {
        
    public int arrival { get; set; }
        public int burst { get; set; }
        public int priority { get; set; }
        public int id { get; set; }
        public int start { get; set; }
        public int end { get; set; }

        public process(int id, int arrival, int burst)
        { this.id = id; this.arrival = arrival; this.burst = burst; }

        public process(int id, int arrival, int burst, int priority)
        { this.id = id; this.arrival = arrival; this.burst = burst; this.priority = priority; }

        public process(int id, int arrival, int burst, int priority, int start, int end)
        { this.id = id; this.arrival = arrival; this.burst = burst; this.priority = priority; this.start = start; this.end = end; }

        public process(process p)
        {
            arrival = p.arrival; burst = p.burst; priority = p.priority; id = p.id; start = p.start; end = p.end;
        }
    }
}
