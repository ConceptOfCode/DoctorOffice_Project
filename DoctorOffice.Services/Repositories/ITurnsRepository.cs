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

        void saveChanges();

        Task<IEnumerable<SecretaryReserveList_ViewModel>> getReserveList();

        Task<SecretaryreserveDetails_ViewModel> getDetails(int turnsID);

        Task<IEnumerable<SecretaryReserveList_ViewModel>> searchList(string reserveDate);
    }
}
