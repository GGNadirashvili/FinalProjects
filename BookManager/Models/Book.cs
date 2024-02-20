﻿namespace BookManager.Models
{
    public record Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int YearOfPublication { get; set; }
    }
}
