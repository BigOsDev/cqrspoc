﻿using CQRS.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models.Common
{
    public class EventAgregate : IEvent
    {
        public int Id { get; set; }
        public int Caller { get; set; }
        public string CallerName { get; set; }
        public int EventType { get; set; }
        public int AgregateType { get; set; }
        public int AgregateId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ProcessedAt { get; set; }
        public bool Succeed { get; set; }
    }
}
