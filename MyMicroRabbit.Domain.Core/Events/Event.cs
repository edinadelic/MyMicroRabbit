using System;
using System.Collections.Generic;
using System.Text;

namespace MyMicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Tiimestamp { get; protected set; }
        protected Event()
        {
            Tiimestamp = DateTime.Now;
        }
    }
}
