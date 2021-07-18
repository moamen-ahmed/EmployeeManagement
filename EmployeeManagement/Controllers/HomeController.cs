﻿using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers

{
    
    public class HomeController :Controller
    {
        private IEmployeeRepository _employeeRepository;

        // public string Index()
        //{
        //    return "Hello from MVC";
        //}
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
    
        public  ViewResult Index()
        {
            var model= _employeeRepository.GetAllEmployee();

            return View(model);
        }

   
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            { 

                employee = _employeeRepository.GetEmployee(id??1),
                PageTitle="Details Title"
            };


            return View(homeDetailsViewModel);
        }

        public ViewResult Create()
        {
            return View();
        }
    }
}