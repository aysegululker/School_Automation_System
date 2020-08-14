using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface INoteEntryService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<NoteEntry> GetActiveNote();

        //Listing All (Listeleme)
        List<NoteEntry> GetNote(Expression<Func<NoteEntry, bool>> exp);

        //Adding (Ekleme)
        void Add(NoteEntry noteEntry);

        //Update (Güncelleme)
        void Update(NoteEntry noteEntry);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        NoteEntry GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<NoteEntry, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<NoteEntry, bool>> exp);
    }
}
