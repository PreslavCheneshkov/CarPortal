using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services.Contracts
{
    public interface IProfileService
    {
        Task<string> CreateProfileAsync(string username, bool isDealer);
    }
}
