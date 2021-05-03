using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SImpleNotepad.Models;

namespace SImpleNotepad.ViewModels
{
    public class MainViewModel
    {
        private DocumentModel _document;
        public EditorViewMoel Editor { get; set; }
        public FileViewModel File { get; set; }
        public HelpViewModel Help { get; set; }

        public MainViewModel()
        {
            _document = new DocumentModel();
            Help = new HelpViewModel();
            Editor = new EditorViewMoel(_document);
            File = new FileViewModel(_document);

        }
    }
}
