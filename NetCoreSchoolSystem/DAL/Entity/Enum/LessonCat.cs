using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.Enum
{
    public enum LessonCat
    {
        //It is created for easy separation of lessons in the scorecard. (Derslerin karnede kolay ayrıştırılabilmesi için oluşturulmuştur.)
        Sayısal = 0, //Numerical
        Sözel = 1, //Verbal
        Yardımcı = 2, //Ancillary
        
    }
}
