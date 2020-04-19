using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.Domains;
using DoctorOffice.ViewModels;

namespace DoctorOffice.Services
{
    public interface ITurnsRepository : IDisposable
    {
        Task<IEnumerable<Turns>> getAllTurns();

        Task<Turns> getTurnsById(int id);

        Task<bool> insertTurns(Turns turns);

        Task<bool> editTurns(Turns turns);

        Task<bool> deleteTurns(Turns turns);

        Task<bool> deleteTurns(int id);

        Task saveChanges();

        Task<IEnumerable<SecretaryReserveList_ViewModel>> getReserveList();

        Task<IEnumerable<PatientReserveList_ViewModel>> getPatientReserveList(string Email);

        Task<SecretaryreserveDetails_ViewModel> getDetails(int turnsID);

        Task<IEnumerable<SecretaryReserveList_ViewModel>> searchList(string reserveDate);

        Task<int> getTurnsCount();

        Task<int> getCountHappyPatients();
    }
}
