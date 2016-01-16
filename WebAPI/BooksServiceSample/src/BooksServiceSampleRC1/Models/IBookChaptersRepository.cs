﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksServiceSampleRC1.Models
{
    public interface IBookChaptersRepository
    {
        void Init();

        void Add(BookChapter chapter);
        BookChapter Remove(string id);
        IEnumerable<BookChapter> GetAll();
        BookChapter Find(string id);
        void Update(BookChapter chapter);
    }
}