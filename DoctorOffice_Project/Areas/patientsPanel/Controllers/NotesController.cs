using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Services;
using DoctorOffice.Domains;
using constantConcepts = DoctorOffice.Enums.constantConcepts;
using Newtonsoft.Json;
using DoctorOffice.ViewModels;
using DoctorOffice.ExtensionMethods;

namespace DoctorOffice_Project.Areas.patientsPanel.Controllers
{
    [Area("patientsPanel")]
    public class NotesController : Controller
    {
        INoteRepository noteRepository;
        public NotesController(INoteRepository note)
        {
            this.noteRepository = note;
        }
        [Route("PatientsPanel/NoteList")]
        public async Task<IActionResult> Index()
        {
            var data = await noteRepository.patientsNoteList(User.Identity.Name);
            return View(data);
        }

        [Route("PatientPanel/Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var data = await noteRepository.Details(id);
            return View(data);
        }

        [HttpGet("PatientPanel/SearchNote/{fromDate}/{toDate}")]
        public async Task<jsonResult> searchNote(string fromDate, string toDate)
        {
            List<PatientsPanelNoteListViewModel> noteList;

            var data = await noteRepository.PatientsSearchNotes();

            checkDate(fromDate.Replace('$','/'), toDate.Replace('$','/'), data, out noteList);

            if (data.Any())
            {
                return jsonResult.GetJsonResult((int)constantConcepts.httpStatus.successed, constantConcepts.httpStatus.successed.ToString(), "/PatientsPanel/NoteList", JsonConvert.SerializeObject(noteList));
            }

            return jsonResult.GetJsonResult((int)constantConcepts.httpStatus.notFound, constantConcepts.httpStatus.notFound.ToString(), "", "");
        }

        public void checkDate(string fromDateParam, string toDateParam, IEnumerable<PatientsPanelNoteListViewModel> CurrentListFromDB, out List<PatientsPanelNoteListViewModel> finalList)
        {
            var fromDate = fromDateParam.toDate();
            var toDate = toDateParam.toDate();
            finalList = new List<PatientsPanelNoteListViewModel>();

            foreach (var item in CurrentListFromDB)
            {
                var baseDate = item.createDateTime.toDate();
                if (baseDate >= fromDate && baseDate <= toDate)
                {
                    finalList.Add(item);
                }
            }
        }
    }
}