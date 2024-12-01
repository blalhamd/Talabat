namespace Talabat.DataAccess.Seed
{
    public static class SeedData
    {
        public static async Task Seed(AppDbContext dbContext)
        {
            if (dbContext is not null)
            {
                if (!await dbContext.ProductTypes.AnyAsync())
                {

                    var ReadTypes = File.ReadAllText("../Talabat.DataAccess/Seed/JsonData/types.json"); // Path From Starting Folder
                    var types = JsonSerializer.Deserialize<List<ProductType>>(ReadTypes);

                    if(types is not null)
                    {
                        foreach (var type in types)
                        {
                            await dbContext.ProductTypes.AddAsync(type);
                        }

                        await dbContext.SaveChangesAsync();
                    }
                }

                if (!await dbContext.Brands.AnyAsync())
                {

                    var ReadBrands = File.ReadAllText("../Talabat.DataAccess/Seed/JsonData/brands.json"); // Path From Starting Folder
                    var brands = JsonSerializer.Deserialize<List<Brand>>(ReadBrands);

                    if(brands is not null)
                    {
                        foreach (var brand in brands)
                        {
                            await dbContext.Brands.AddAsync(brand);
                        }

                        await dbContext.SaveChangesAsync();
                    }
                }

                if (!await dbContext.Products.AnyAsync())
                {

                    var ReadProducts = File.ReadAllText("../Talabat.DataAccess/Seed/JsonData/products.json"); // Path From Starting Folder
                    var Products = JsonSerializer.Deserialize<List<Product>>(ReadProducts);

                    if(Products is not null)
                    {
                        foreach (var prod in Products)
                        {
                            await dbContext.Products.AddAsync(prod);
                        }

                        await dbContext.SaveChangesAsync();
                    }
                }

                if (!await dbContext.DeliveryMethods.AnyAsync())
                {
                    var ReadDataFromJson = File.ReadAllText("../Talabat.DataAccess/Seed/JsonData/delivery.json");
                    var deliveryMethods = JsonSerializer.Deserialize<List<DeliveryMethod>>(ReadDataFromJson);

                    if (deliveryMethods is not null)
                    {
                        foreach (var item in deliveryMethods)
                        {
                            await dbContext.DeliveryMethods.AddAsync(item);
                        }

                        await dbContext.SaveChangesAsync();
                    }
                }

                await dbContext.SaveChangesAsync();
            }

        }
    }
}

/*
 
  -- Bad Practice

                    if(Products is not null)
                    {
                        foreach (var prod in Products)
                        {
                            await dbContext.Products.AddAsync(prod);
                            await dbContext.SaveChangesAsync();
                        }

                    }
 
  -- Good Practice as Performace

                    if(Products is not null)
                    {
                        foreach (var prod in Products)
                        {
                            await dbContext.Products.AddAsync(prod);
                        }
                            await dbContext.SaveChangesAsync();
                    }

 */

