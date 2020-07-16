using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class StudentSuccessDocument
    {
        public Guid StudentID { get; set; }
        public Guid SuccessDocumentID { get; set; }

        public Student Student { get; set; }
        public SuccessDocument SuccessDocument { get; set; }

    }
}
