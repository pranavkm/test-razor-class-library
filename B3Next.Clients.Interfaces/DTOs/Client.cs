using System;
using System.Collections.Generic;
using System.Text;

namespace B3Next.Clients.Interfaces.DTOs
{
    public class Client
    {
        public long Id { get; set; }
        public short Kind { get; set; }
        public string Name { get; set; }
        public string PersonalId { get; set; }
    }
}
