using System;
using System.Collections.Generic;
using System.Text;
using DoctorOffice.Domains;
using System.Threading.Tasks;
using DoctorOffice.ViewModels;

namespace DoctorOffice.Services
{
    public interface INoteRepository : IDisposable
    {
        Task<IEnumerable<Notes>> getAllNotes();

        Task<Notes> getNotesById(int id);

        Task<bool> insertNotes(Notes notes);

        Task<bool> editNotes(Notes notes);

        Task<bool> deleteNotes(Notes notes);

        Task<bool> deleteNotes(int id);

        Task<bool> deleteNoteWithTurnsID(int turnsID);

        Task saveChanges();

        Task<IEnumerable<DoctorPanelNoteListViewModel>> NoteList();

        Task<IEnumerable<PatientsPanelNoteListViewModel>> patientsNoteList(string PatientEmail);

        Task<DoctorPanelDetailsViewModel> Details(int id);

        Task<IEnumerable<DoctorPanelSearchNotesViewModel>> searchNotes(int nationalID);
    }
}