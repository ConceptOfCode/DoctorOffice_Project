using DoctorOffice.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.ViewModels;

namespace DoctorOffice.Services
{
    public interface IDoctorsPrescriptionsRepository : IDisposable
    {
        Task<IEnumerable<doctorsPrescription>> getAllDoctorsPrescription();

        Task<doctorsPrescription> getDoctorsPrescriptionById(int id);

        Task<bool> insertDoctorsPrescription(doctorsPrescription doctorsPrescription);

        Task<bool> editDoctorsPrescription(doctorsPrescription doctorsPrescription);

        Task<bool> deleteDoctorsPrescription(doctorsPrescription doctorsPrescription);

        Task<bool> deleteDoctorsPrescription(int id);

        Task saveChanges();

        Task<IEnumerable<DoctorPanelPrescriptionListViewModel>> PrescriptionList();

        Task<DoctorPanelNewPrescriptionInfoViewModel> insertInfo(int turnsID);

        Task<IEnumerable<DoctorPanelEditPrescriptionViewModel>> findDataForEdit(int prescriptionID);
    }
}
