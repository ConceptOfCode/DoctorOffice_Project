using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Domains;
using DoctorOffice.Services;
using DoctorOffice.ViewModels;
using DoctorOffice.ExtensionMethods;
using constantConcepts = DoctorOffice.Enums.constantConcepts;
using Newtonsoft.Json;

namespace DoctorOffice_Project.Areas.doctorPanel.Controllers
{
    [Area("doctorPanel")]
    public class PrescriptionController : Controller
    {
        IDoctorsPrescriptionsRepository doctorsPrescriptionsRepository;
        IMedicinesRpository medicinesRpository;
        IHowUsesRepository howUsesRepository;
        INoteRepository noteRepository;

        public PrescriptionController(IDoctorsPrescriptionsRepository Prescriptions, IMedicinesRpository medicines, IHowUsesRepository howUses, INoteRepository note)
        {
            this.doctorsPrescriptionsRepository = Prescriptions;
            this.medicinesRpository = medicines;
            this.howUsesRepository = howUses;
            this.noteRepository = note;
        }

        [Route("DoctroPanel/PrescriptionList")]
        public async Task<IActionResult> Index()
        {
            var data = await doctorsPrescriptionsRepository.PrescriptionList();
            return View(data);
        }

        [Route("DoctroPanel/newPrescription/{turnsID}")]
        public async Task<IActionResult> insertData(int turnsID)
        {
            var data = await doctorsPrescriptionsRepository.insertInfo(turnsID);
            return await Task.Run(() => View(data));
        }

        [HttpPost("DoctorPanel/AddPrescription")]
        public async Task<IActionResult> insertData(DoctorPanelNewPrescriptionViewModel[] medicines, Notes note)
        {
            doctorsPrescription doctorsPrescription = new doctorsPrescription()
            {
                turnsID = medicines.First().turnsID,
                createDate = DateTime.Now.toShamsi(),
                prescriptionStatus = (int)constantConcepts.Status.success
            };

            var PrescriptionResult = await doctorsPrescriptionsRepository.insertDoctorsPrescription(doctorsPrescription);
            if (PrescriptionResult == true)
            {
                await doctorsPrescriptionsRepository.saveChanges();
            }
            var PrescriptionLastID = doctorsPrescription.doctorsPrescriptionID;

            foreach (var item in medicines)
            {
                using (var medicine = new Medicine())
                {
                    medicine.doctorsPrescriptionID = PrescriptionLastID;
                    medicine.medicineName = item.medicineName;
                    medicine.createDate = DateTime.Now.toShamsi();
                    medicine.Descriptions = "";

                    var medicineResult = await medicinesRpository.insertMedicine(medicine);
                    if (medicineResult == true)
                    {
                        await medicinesRpository.saveChanges();
                    }

                    var medicineLastID = medicine.medicineID;

                    using (var howuse = new howUse())
                    {
                        howuse.medicineID = medicineLastID;
                        howuse.howUseText = item.howUseText;
                        howuse.useFrom = item.fromDate;
                        howuse.useTo = item.toDate;
                        howuse.createDate = DateTime.Now.toShamsi();
                        howuse.Descriptions = "";

                        var howUseResult = await howUsesRepository.inserthowUse(howuse);
                        if (howUseResult == true)
                        {
                            await howUsesRepository.saveChanges();
                        }
                    }
                }
            }

            using (var notes = new Notes())
            {
                notes.createDate = DateTime.Now.toShamsi();
                notes.turnsID = medicines.First().turnsID;
                notes.titleNote = note.titleNote;
                notes.fullTextNote = note.fullTextNote;
                var noteResult = await noteRepository.insertNotes(notes);
                if (noteResult == true)
                {
                    await noteRepository.saveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [Route("DoctorPanel/EditPrescription/{prescriptionID}")]
        public async Task<IActionResult> updateData(int prescriptionID)
        {
            var data = await doctorsPrescriptionsRepository.findDataForEdit(prescriptionID);
            return View(data);
        }

        [HttpPost("DoctorPanel/EditPrescriptions")]
        public async Task<IActionResult> updateData(doctorPanelSendForEditPrescriptionViewModel[] medicines)
        {
            using (var prescription = new doctorsPrescription())
            {
                prescription.doctorsPrescriptionID = medicines.First().prescriptionID;
                prescription.turnsID = medicines.First().turnsID;
                prescription.createDate = DateTime.Now.toShamsi();
                prescription.prescriptionStatus = (int)constantConcepts.Status.success;
                prescription.PrescriptionDescriptions = "";

                var prescriptionResult = await doctorsPrescriptionsRepository.editDoctorsPrescription(prescription);
                if (prescriptionResult == true)
                {
                    await doctorsPrescriptionsRepository.saveChanges();
                }
            }

            foreach (var item in medicines)
            {
                using (var medicine = new Medicine())
                {
                    medicine.medicineID = item.medicineID;
                    medicine.doctorsPrescriptionID = medicines.First().prescriptionID;
                    medicine.medicineName = item.medicineName;
                    medicine.createDate = DateTime.Now.toShamsi();
                    medicine.Descriptions = "";

                    var medicineResult = await medicinesRpository.editMedicine(medicine);
                    if (medicineResult == true)
                    {
                        await medicinesRpository.saveChanges();
                    }

                    using (var howuse = new howUse())
                    {
                        howuse.howUseID = item.howUseID;
                        howuse.medicineID = item.medicineID;
                        howuse.howUseText = item.howUseText;
                        howuse.useFrom = item.fromDate;
                        howuse.useTo = item.toDate;
                        howuse.createDate = DateTime.Now.toShamsi();
                        howuse.Descriptions = "";

                        var howUseResult = await howUsesRepository.edithowUse(howuse);
                        if (howUseResult == true)
                        {
                            await howUsesRepository.saveChanges();
                        }
                    }
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet("/DoctorPanel/DeleteMedicine/{prescriptionID}/{turnsID}")]
        public async Task<jsonResult> deleteData(int prescriptionID, int turnsID)
        {
            var result = await doctorsPrescriptionsRepository.deleteDoctorsPrescription(prescriptionID);
            if (result == true)
            {
                await doctorsPrescriptionsRepository.saveChanges();

                var noteResult = await noteRepository.deleteNoteWithTurnsID(turnsID);
                if (noteResult == true)
                {
                    await noteRepository.saveChanges();
                }

                return jsonResult.GetJsonResult(200, constantConcepts.Status.success.ToString(), "/DoctroPanel/PrescriptionList", "");
            }

            return jsonResult.GetJsonResult((int)constantConcepts.Status.error, constantConcepts.httpStatus.badRequest.ToString(), "", "");
        }

        [HttpGet("DoctorPanel/SearchPrescription/{nationalID}")]
        public async Task<jsonResult> searchPrescription(int nationalID)
        {
            var data = await doctorsPrescriptionsRepository.PrescriptionList();
            data = data.Where(w => w.PatientNationalID == nationalID || w.temporaryPatientNationalID == nationalID);

            if (data.Any())
            {
                return jsonResult.GetJsonResult((int)constantConcepts.httpStatus.successed, constantConcepts.httpStatus.successed.ToString(), "", JsonConvert.SerializeObject(data));
            }
            else
            {
                return jsonResult.GetJsonResult((int)constantConcepts.httpStatus.notFound, constantConcepts.httpStatus.notFound.ToString(), "", "");
            }
        }
    }
}