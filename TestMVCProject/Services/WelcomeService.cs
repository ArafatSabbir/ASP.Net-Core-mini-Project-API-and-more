using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMVCProject.Models;

namespace TestMVCProject.Services
{
    public class WelcomeService
    {
        public WelcomeModel GetWelcomeModel()
        {
            var model = new WelcomeModel();

            var data = new WelcomeRepo().GetWelcomeData();

            model.Name = data[0];
            model.Date = DateTime.Parse(data[1]);

            return model;
        }
    }
}
