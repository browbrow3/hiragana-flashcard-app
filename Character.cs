using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiraganaFlashcards {
    public record Character
    {
        public int Id { get; init; }
        public char Char { get; init; }
        public string Sound { get; init; }
    }
}