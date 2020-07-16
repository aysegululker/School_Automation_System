using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class TeacherNoteEntry
    {
        public Guid TeacherID { get; set; }
        public Guid NoteEntryID { get; set; }

        public Teacher Teacher { get; set; }
        public NoteEntry NoteEntry { get; set; }
    }
}
