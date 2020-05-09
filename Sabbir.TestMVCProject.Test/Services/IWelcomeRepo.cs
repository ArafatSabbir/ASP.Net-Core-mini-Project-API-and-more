using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMVCProject.Services
{
    public interface IWelcomeRepo
    {
        List<string> GetWelcomeData();
    }
}
