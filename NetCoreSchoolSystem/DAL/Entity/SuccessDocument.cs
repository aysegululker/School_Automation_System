using DAL.Entity.Base;
using DAL.Entity.ManyToMany;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entity
{
    public class SuccessDocument:CoreEntity
    {

        public PeriodInformation LessonYear { get; set; } //Ders Yılı
        public PeriodInformation PeriodName { get; set; } //Dönem Adı...1.Dönem - 2.Dönem
        public SuccessDocumentIdentification DocumentName { get; set; } //Döküman adı


        //ManyToMany
        public virtual List<StudentSuccessDocument> StudentSuccessDocuments { get; set; } //A student has more than one sucdocument. (Bir öğrencinin birden fazla başarı belgesi olabilir. Takdir + Onur Belgesi)
    }
}
