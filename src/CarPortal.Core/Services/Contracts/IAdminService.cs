using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services.Contracts
{
    public interface IAdminService
    {
        public Task<Tuple<int, int>> GetIndexPageData();
    }
}
