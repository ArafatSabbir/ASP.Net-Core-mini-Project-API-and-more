using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMVCProject.Models;

namespace TestMVCProject.Services
{
    public interface IWelcomeService
    {
        WelcomeModel GetWelcomeModel();

    }
}
