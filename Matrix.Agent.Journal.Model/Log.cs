﻿using System;
using System.Collections.Generic;

namespace Matrix.Agent.Journal.Model
{
    public class Log
    {
        public Guid Id { get; set; }

        public Guid Application { get; set; }

        public bool Enabled { get; set; }

        public DateTime Timestamp { get; set; }

        public string Source { get; set; }

        public int Level { get; set; }

        public int Event { get; set; }

        public string Message { get; set; }

        public Dictionary<string, string> Properties { get; set; }

        public List<string> Tags { get; set; }

        public Log()
        {
            Properties = new Dictionary<string, string>();
            Tags = new List<string>();
        }
    }
}