using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Domains;
using DoctorOffice.Services;
using DoctorOffice.ExtensionMethods;
using constantConcepts = DoctorOffice.Enums.constantConcepts;
using DoctorOffice.ViewModels;
using Newtonsoft.Json;

namespace DoctorOffice_Project.Areas.doctorPanel.Controllers
{
    [Area("doctorPanel")]
    public class NotesController : Controller
    {
        INoteRepository notesRepository;
        public NotesController(INoteRepository note)
        {
            this.notesRepository = note;
        }

        [Route("DoctorPanel/NoteList")]
        public async Task<IActionResult> Index()
        {
            var data = await notesRepository.NoteList();
            return View(data);
        }

        [Route("DoctorPanel/newNote/{turnsID}")]
        public async Task<IActionResult> insertData(int turnsID)
        {
            ViewBag.turnsID = turnsID;
            return await Task.Run(() => View());
        }

        [HttpPost("DoctorPanel/insertNote")]
        public async Task<IActionResult> insertData(Notes notes)
        {
            notes.createDate = DateTime.Now.toShamsi();
            var result = await notesRepository.insertNotes(notes);
            if (result == true)
            {
                await notesRepository.saveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [Route("DoctorPanel/EditNote/{id}")]
        public async Task<IActionResult> updateData(int id)
        {
            var existsNote = await notesRepository.getNotesById(id);
            return View(existsNote);
        }

        [HttpPost("DoctorPanel/EditNote")]
        public async Task<IActionResult> updateData(Notes notes)
        {
            notes.createDate = DateTime.Now.toShamsi();
            var result = await notesRepository.editNotes(notes);
            if (result == true)
            {
                await notesRepository.saveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet("DoctorPanel/DeleteNote/{id}")]
        public async Task<jsonResult> deleteData(int id)
        {
            var find = await notesRepository.getNotesById(id);
            var result = await notesRepository.deleteNotes(find);
            if (result == true)
            {
                await notesRepository.saveChanges();
                return jsonResult.GetJsonResult(200, constantConcepts.Status.success.ToString(), "/DoctorPanel/NoteList", "");
            }

            return jsonResult.GetJsonResult((int)constantConcepts.httpStatus.internalServerError, constantConcepts.Status.error.ToString(), "", "");
        }

        [Route("DoctorPanel/Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var note = await notesRepository.Details(id);
            return View(note);
        }

        [HttpGet("DoctorPanel/SearchNotes/{nationalID}")]
        public async Task<jsonResult> Search(int nationalID)
        {
            var data = await notesRepository.searchNotes(nationalID);
            if (data != null && data.Any())
            {
                return jsonResult.GetJsonResult(200, constantConcepts.Status.success.ToString(), "", JsonConvert.SerializeObject(data));
            }
            else
            {
                return jsonResult.GetJsonResult((int)constantConcepts.httpStatus.notFound, constantConcepts.Status.error.ToString(), "", "");
            }
        }
    }
}