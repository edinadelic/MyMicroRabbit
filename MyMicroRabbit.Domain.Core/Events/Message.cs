﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MyMicroRabbit.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }
        private Message()
        {
            MessageType = GetType().Name;
        }
    }
}