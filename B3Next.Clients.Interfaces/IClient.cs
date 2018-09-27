using B3Next.Clients.Interfaces.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;

namespace B3Next.Clients.Interfaces
{
    public interface IClient
    {
        IEnumerable<Client> GetClients();
    }
}
