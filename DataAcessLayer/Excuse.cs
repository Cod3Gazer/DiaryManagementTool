﻿using System;

namespace DataAccessLayer
{
    public class Excuse
    {
        public int ExcuseId { get; set; }
        public DateTime ExcuseDate { get; set; }
        public TimeSpan ExcuseTime { get; set; }
        public DateTime NextFollowUpDate { get; set; }
        public string ExcuseDesc { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
