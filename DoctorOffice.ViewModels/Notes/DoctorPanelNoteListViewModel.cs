using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
    public class DoctorPanelNoteListViewModel
    {
        public int NoteID { get; set; }
        public int TurnsID { get; set; }
        public string noteTitle { get; set; }
        public string fullNoteText { get; set; }
        public string doctorFullName { get; set; }
        public string createDateTime { get; set; }
    }
}
