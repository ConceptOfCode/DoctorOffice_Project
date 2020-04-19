using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Domains;
using DoctorOffice.Enums;
using DoctorOffice.Services;

namespace DoctorOffice_Project.Controllers
{
    public class localAPIController : Controller
    {
        IEmployeesRepository employeesRepository;
        ITurnsRepository turnsRepository;
        IPatientsRepository patientsRepository;

        public localAPIController(IEmployeesRepository employees, ITurnsRepository turns, IPatientsRepository patients)
        {
            this.employeesRepository = employees;
            this.turnsRepository = turns;
            this.patientsRepository = patients;
        }

        [HttpGet("getCountDoctorEmployees")]
        public async Task<int> doctorCount()
        {
            return await employeesRepository.GetDoctorCount();
        }

        [HttpGet("getCountPatients")]
        public async Task<int> patientCount()
        {
            return await patientsRepository.getPatientsCount();
        }

        [HttpGet("getCountTurns")]
        public async Task<int> turnsCount()
        {
            return await turnsRepository.getTurnsCount();
        }

        [HttpGet("getCountHappyPatients")]
        public async Task<int> getCountHappyPatients()
        {
            return await turnsRepository.getCountHappyPatients();
        }
    }
}