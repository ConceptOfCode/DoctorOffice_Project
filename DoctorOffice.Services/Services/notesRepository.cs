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
using System.Globalization;

namespace DoctorOffice.Services
{
    public class notesRepository : INoteRepository
    {
        ProjectContext db;
        public notesRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<Notes>> getAllNotes()
        {
            return await Task.Run(() => db.Notes);
        }

        public async Task<Notes> getNotesById(int id)
        {
            return await db.Notes.FindAsync(id);
        }

        public async Task<bool> insertNotes(Notes notes)
        {
            try
            {
                await db.Notes.AddAsync(notes);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editNotes(Notes notes)
        {
            try
            {
                await Task.Run(() => db.Entry(notes).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteNotes(Notes notes)
        {
            try
            {
                await Task.Run(() => db.Entry(notes).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteNotes(int id)
        {
            try
            {
                Notes find = await getNotesById(id);
                await deleteNotes(find);
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

        public async Task<IEnumerable<DoctorPanelNoteListViewModel>> NoteList()
        {
            return await Task.Run(() => db.Notes.Select(s => new DoctorPanelNoteListViewModel()
            {
                NoteID = s.noteID,
                TurnsID = s.Turns.turnsID,
                noteTitle = s.titleNote,
                doctorFullName = s.Turns.Employees.firstName + " " + s.Turns.Employees.lastName,
                createDateTime = s.createDate,
                fullNoteText = s.fullTextNote
            }));
        }

        public async Task<IEnumerable<PatientsPanelNoteListViewModel>> patientsNoteList(string PatientEmail)
        {
            return await Task.Run(() => db.Notes.Select(s => new PatientsPanelNoteListViewModel()
            {
                NoteID = s.noteID,
                TurnsID = s.turnsID,
                patientID = s.Turns.Patients.patientsID,
                patientEmail = s.Turns.Patients.Email,
                noteTitle = s.titleNote,
                fullNoteText = s.fullTextNote,
                doctorFullName = s.Turns.Employees.firstName + " " + s.Turns.Employees.lastName,
                createDateTime = s.createDate
            }).Where(w => w.patientEmail == PatientEmail));
        }

        public async Task<DoctorPanelDetailsViewModel> Details(int id)
        {
            return await db.Notes.Select(s => new DoctorPanelDetailsViewModel()
            {
                NoteID = s.noteID,
                TurnsID = s.Turns.turnsID,
                noteTitle = s.titleNote,
                doctorFullName = s.Turns.Employees.firstName + " " + s.Turns.Employees.lastName,
                createDateTime = s.createDate,
                fullNoteText = s.fullTextNote
            }).Where(w => w.NoteID == id).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<DoctorPanelSearchNotesViewModel>> searchNotes(int nationalID)
        {
            return await Task.Run(() => db.Notes.Select(s => new DoctorPanelSearchNotesViewModel()
            {
                NoteID = s.noteID,
                TurnsID = s.Turns.turnsID,
                noteTitle = s.titleNote,
                doctorFullName = s.Turns.Employees.firstName + " " + s.Turns.Employees.lastName,
                createDateTime = s.createDate,
                fullNoteText = s.fullTextNote,
                PatientNationalID = s.Turns.Patients.nationalNumber
            }).Where(w => w.PatientNationalID == nationalID));
        }

        public async Task<bool> deleteNoteWithTurnsID(int turnsID)
        {
            try
            {
                var find = db.Notes.Where(w => w.turnsID == turnsID);

                foreach (var item in find)
                {
                    var result = await deleteNotes(item);
                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
