using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entity
{
    public class SuccessDocumentIdentification:CoreEntity
    {

        public string DocumentName { get; set; } //Döküman adı
    }
}
