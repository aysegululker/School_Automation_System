using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class TeacherNoteEntry:CoreEntity
    {
        public Guid TeacherID { get; set; }
        public Teacher Teacher { get; set; }


        public Guid NoteEntryID { get; set; }
        public NoteEntry NoteEntry { get; set; }
    }
}
