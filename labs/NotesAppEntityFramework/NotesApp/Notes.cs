using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NotesApp {
    public class Notes {
        public static List<Note> GetNotes() {
            var context = new NotesAppEntities();
            var notes =
                from n in context.Notes
                orderby n.Name
                select n;
            return notes.ToList();
        }

        public static bool AddNote(Note note) {
            var context = new NotesAppEntities();
            context.Notes.Add(note);
            context.SaveChanges();
            return true;
        }

        public static Note GetNote(int id) {
            var context = new NotesAppEntities();
            return context.Notes.Find(id);
        }

        public static bool UpdateNote(Note note, string newContent) {
            var context = new NotesAppEntities();
            note = context.Notes.Find(note.Id);
            note.Content = newContent;
            context.SaveChanges();
            return true;
        }
    }
}
