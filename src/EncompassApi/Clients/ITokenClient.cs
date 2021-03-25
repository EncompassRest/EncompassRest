using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.Clients
{
    public interface ITokenClient
    {
        Task<string> GetToken();
    }
}
