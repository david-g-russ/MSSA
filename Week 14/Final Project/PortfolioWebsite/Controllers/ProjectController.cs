﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using PortfolioWebsite.Models;

namespace PortfolioWebsite.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectRepository _tempRepository;
        
        public ProjectController(IProjectRepository tempRepository)
        {
            _tempRepository = tempRepository;
        }

        public IActionResult Index()
        {
            AllProjectsView allProjectsView = new()
            {
                Projects = _tempRepository.InitializeProjects()
            };
            return View(allProjectsView);
        }

        public IActionResult Single(int? id)
        {
            var model = _tempRepository.GetProject(id);
            if(model == null)
                return NotFound();
            return View(model);
        }

        public IActionResult Details(int? id)
        {
            var model = _tempRepository.GetProject(id);
            if (model == null)
                return NotFound();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project proj)
        {
            if (ModelState.IsValid)
            {
                _tempRepository.AddProject(proj);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            var model = _tempRepository.GetProject(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Project proj, int id)
        {
            proj.Id = id;
            _tempRepository.UpdateProject(proj);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            var model = _tempRepository.GetProject(id);
            if (model != null)
                _tempRepository.DeleteProject(id);
            return RedirectToAction("Index");
        }
    }
}