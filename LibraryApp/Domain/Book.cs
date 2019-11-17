﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PublishingYear { get; set; }
        public int AuthoredYear { get; set; }
        public int WordCount { get; set; }
        public string Summary { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}