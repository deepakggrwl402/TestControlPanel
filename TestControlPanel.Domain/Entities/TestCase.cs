﻿namespace TestControlPanel.Domain.Entities
{
    public class TestCase
    {
        public int Id { get; set; }
        public string? TestTitle { get; set; }
        public DateTime TestDate { get; set; }
        public string? TestDescription { get; set; }
    }
}