﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAgencyIdentity.Data.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerUser Customer { get; set; }
        public EventType EventType { get; set; }
        public int AddressNumber { get; set; }
        public string Postalcode { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public ICollection<ModelUser> Models { get; set; }
    }
}
