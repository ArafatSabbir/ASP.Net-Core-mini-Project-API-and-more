using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMVCProject.Services
{
    public class WelcomeRepo : IWelcomeRepo
    {
        public List<string> GetWelcomeData()
        {
            var data = new List<string>();
            data.Add("Sabbir");
            data.Add("04/01/1997");

            return data;

        }
    }
}
