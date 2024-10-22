﻿namespace Catalog.Products.Models
    {
    public class Product : Entity<Guid>
        {
        public string Name { get; private set; } = default!;

        public List<string> Category { get; private set; } = new();

        public string Description { get; private set; } = default!;

        public string ImageFile { get; private set; } = default!;

        public decimal Price { get; private set; } = default!;

        public static Product Create(Guid id, string name, List<string> category,
            string description, string imageFile, decimal price)
            {
            ArgumentException.ThrowIfNullOrEmpty(name);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

            var product = new Product()
                {
                Id = id,
                Name = name,
                Category = category,
                Description = description,
                ImageFile = imageFile,
                Price = price
                };
            return product;

            }
        
    public void Update(string name, List<string> category,
            string description, string imagefile, decimal price)
            {
            ArgumentException.ThrowIfNullOrEmpty(name);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

            Name = name;
            Category = category;
            Description = description;
            ImageFile = imagefile;
            Price = price;

            //TODO : if price changed Raise ProductPriceChanged domain event
      

            }
        }
