﻿namespace NLayer.MVC.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Slug { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }

        public List<string>? Photo { get; set; }
        public float Price { get; set; }
        public bool IsActive { get; set; }
        public string? Brand { get; set; }

        //property!
        public List<Comment>? Comments { get; set; }

    }
}
