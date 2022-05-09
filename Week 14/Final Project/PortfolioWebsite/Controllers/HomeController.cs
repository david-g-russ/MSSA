using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortfolioWebsite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioWebsite.Controllers
{
    public class HomeController : Controller
    {
        private IProjectRepository _projectRepository;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            AllProjectsView allProjectsView = new()
            {
                Projects = _projectRepository.InitializeProjects()
            };
            return View(allProjectsView);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
