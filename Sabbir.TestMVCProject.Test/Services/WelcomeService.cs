using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMVCProject.Models;

namespace TestMVCProject.Services
{
    public class WelcomeService : IWelcomeService
    {
        private readonly IWelcomeRepo _welcomeRepo;

        public WelcomeService(IWelcomeRepo welcomeRepo)
        {
            _welcomeRepo = welcomeRepo;
        
        }

        public WelcomeModel GetWelcomeModel()
        {
            var model = new WelcomeModel();

            var data = _welcomeRepo.GetWelcomeData();

            model.Name = data[0];
            model.Date = DateTime.Parse(data[1]);

            return model;
        }
    }
}
