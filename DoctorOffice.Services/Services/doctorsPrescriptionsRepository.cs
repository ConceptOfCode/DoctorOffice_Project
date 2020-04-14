using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.DataLayer;
using DoctorOffice.Domains;
using DoctorOffice.ViewModels;
using Microsoft.EntityFrameworkCore;
using DoctorOffice.ExtensionMethods;

namespace DoctorOffice.Services
{
    public class doctorsPrescriptionsRepository : IDoctorsPrescriptionsRepository
    {
        ProjectContext db;
        public doctorsPrescriptionsRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<doctorsPrescription>> getAllDoctorsPrescription()
        {
            return await Task.Run(() => db.doctorsPrescriptions);
        }

        public async Task<doctorsPrescription> getDoctorsPrescriptionById(int id)
        {
            return await db.doctorsPrescriptions.FindAsync(id);
        }

        public async Task<bool> insertDoctorsPrescription(doctorsPrescription doctorsPrescription)
        {
            try
            {
                await db.doctorsPrescriptions.AddAsync(doctorsPrescription);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editDoctorsPrescription(doctorsPrescription doctorsPrescription)
        {
            try
            {
                await Task.Run(() => db.Entry(doctorsPrescription).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteDoctorsPrescription(doctorsPrescription doctorsPrescription)
        {
            try
            {
                await Task.Run(() => db.Entry(doctorsPrescription).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteDoctorsPrescription(int id)
        {
            try
            {
                doctorsPrescription find = await getDoctorsPrescriptionById(id);
                await deleteDoctorsPrescription(find);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task saveChanges()
        {
            await db.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await db.DisposeAsync();
        }

        public async Task<IEnumerable<DoctorPanelPrescriptionListViewModel>> PrescriptionList()
        {
            return await Task.Run(() => db.doctorsPrescriptions.Select(s => new DoctorPanelPrescriptionListViewModel()
            {
                PrescriptionsID = s.doctorsPrescriptionID,
                turnsID = s.turnsID,
                patientFullName = s.Turns.Patients.firstName + " " + s.Turns.Patients.lastName,
                temporaryPatientFullName = s.Turns.temporaryPatients.firstName + " " + s.Turns.temporaryPatients.lastName,
                PatientNationalID = s.Turns.Patients.nationalNumber,
                temporaryPatientNationalID = s.Turns.temporaryPatients.nationalNumber,
                createDateTime = s.createDate,
                doctorFullNasme = s.Turns.Employees.firstName + " " + s.Turns.Employees.lastName
            }));
        }

        public async Task<DoctorPanelNewPrescriptionInfoViewModel> insertInfo(int turnsID)
        {
            return await db.Turns.Select(s => new DoctorPanelNewPrescriptionInfoViewModel()
            {
                turnsID = s.turnsID,
                patientFullName = !((s.patientsID).IsEmptyOrNull()) ? (s.Patients.firstName + " " + s.Patients.lastName) : (s.temporaryPatients.firstName + " " + s.temporaryPatients.lastName),
                PatientNationalID = !((s.patientsID).IsEmptyOrNull()) ? (s.Patients.nationalNumber) : (s.temporaryPatients.nationalNumber),
                doctorFullNane = s.Employees.firstName + " " + s.Employees.lastName
            }).Where(w => w.turnsID == turnsID).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<DoctorPanelEditPrescriptionViewModel>> findDataForEdit(int prescriptionID)
        {
            return await Task.Run(() => db.howUses.Select(s => new DoctorPanelEditPrescriptionViewModel()
            {
                doctorPrescriptionID = s.Medicine.DoctosPrescription.doctorsPrescriptionID,
                medicineID = s.medicineID,
                howUsesID = s.howUseID,
                turnsID = s.Medicine.DoctosPrescription.turnsID,
                patientFullName = !(s.Medicine.DoctosPrescription.Turns.patientsID.IsEmptyOrNull()) ? (s.Medicine.DoctosPrescription.Turns.Patients.firstName + " " + s.Medicine.DoctosPrescription.Turns.Patients.lastName) : (s.Medicine.DoctosPrescription.Turns.temporaryPatients.firstName + " " + s.Medicine.DoctosPrescription.Turns.temporaryPatients.lastName),
                patientNationalID = !(s.Medicine.DoctosPrescription.Turns.patientsID.IsEmptyOrNull()) ? (s.Medicine.DoctosPrescription.Turns.Patients.nationalNumber) : (s.Medicine.DoctosPrescription.Turns.temporaryPatients.nationalNumber),
                doctorFullName = s.Medicine.DoctosPrescription.Turns.Employees.firstName + " " + s.Medicine.DoctosPrescription.Turns.Employees.lastName,
                medicineName = s.Medicine.medicineName,
                howUsesFullText = s.howUseText,
                fromDate = s.useFrom,
                toDate = s.useTo
            }).Where(w => w.doctorPrescriptionID == prescriptionID));
        }
    }
}
