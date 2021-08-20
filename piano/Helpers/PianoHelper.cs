using piano.Piano;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piano.Helpers
{
    public class PianoHelper
    {
        public static NoteEnum StringNoteToEnum(String note)
        {
            switch(note.ToUpper())
            {
                case "DO":
                    return NoteEnum.DO;
                case "RE":
                    return NoteEnum.RE;
                case "MI":
                    return NoteEnum.MI;
                case "FA":
                    return NoteEnum.FA;
                case "SOL":
                    return NoteEnum.SOL;
                case "LA":
                    return NoteEnum.LA;
                case "SI":
                    return NoteEnum.SI;
                case "DOO":
                    return NoteEnum.DOO;
                default:
                    return NoteEnum.DO;
            }
        }
    }
}
