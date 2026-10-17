//using BrightStars.Data;
//using BrightStars.Models;
//using Microsoft.EntityFrameworkCore;

//AppDbContext context = new AppDbContext();

//////Product firstOrDefaultProductWithId3 = context.Products.FirstOrDefault(p => p.Id == 3);
//////Console.WriteLine("\n((" + nameof(firstOrDefaultProductWithId3) + ")))");
//////Console.WriteLine(firstOrDefaultProductWithId3.ToString());

//////Product findProductWithId3 = context.Products.Find(3);
//////Console.WriteLine("\n((" + nameof(findProductWithId3) + ")))");
//////Console.WriteLine(findProductWithId3.ToString());

//////Product findProductWithId79 = context.Products.Find(79);

//////Console.WriteLine("\n((" + nameof(findProductWithId79) + ")))");
//////if (findProductWithId79 == null)
//////{
//////    Console.WriteLine("There is no product with Id 79");
//////}
//////else
//////{
//////    Console.WriteLine(findProductWithId79.ToString());
//////}

////// Sorting/Ordering


//////Last() & LastOrDefault()

//////// Sorting/Ordering (Part 2)

////List<Product> productsPriceAsc = context.Products.OrderBy(p => p.Price).ToList();
////PrintProducts(productsPriceAsc, nameof(productsPriceAsc));

////List<Product> productsPriceAscThenByNameAsc = context.Products.OrderBy(p => p.Price).ThenBy(p => p.Name).ToList();
////PrintProducts(productsPriceAscThenByNameAsc, nameof(productsPriceAscThenByNameAsc));

////List<Product> productsPriceAscThenByNameDesc = context.Products.OrderBy(p => p.Price).ThenByDescending(p => p.Name).ToList();
////PrintProducts(productsPriceAscThenByNameDesc, nameof(productsPriceAscThenByNameDesc));

////List<Product> productsPriceDesc = context.Products.OrderByDescending(p => p.Price).ToList();
////PrintProducts(productsPriceDesc, nameof(productsPriceDesc));

////List<Product> productsPriceDescThenByNameDesc = context.Products.OrderByDescending(p => p.Price).ThenByDescending(p => p.Name).ToList();
////PrintProducts(productsPriceDescThenByNameDesc, nameof(productsPriceDescThenByNameDesc));

////List<Product> productsPriceDescThenByNameAsc = context.Products.OrderByDescending(p => p.Price).ThenBy(p => p.Name).ToList();
////PrintProducts(productsPriceDescThenByNameAsc, nameof(productsPriceDescThenByNameAsc));

////void PrintProducts(List<Product> products, string productsTitle)
////{
////    Console.WriteLine("((" + productsTitle + ")))");
////    foreach (var product in products)
////        Console.WriteLine(product.ToString());
////}
////context.Remove(context.Products.Find(6));
////context.SaveChanges();
////Console.WriteLine($"Product with id 6 is deleted successfully");


////bool isThereAnyItemInProducts = context.Products.Any();
////Console.WriteLine($"{nameof(isThereAnyItemInProducts)} ? {isThereAnyItemInProducts}");

////bool isThereAnyNameContainsIS = context.Products.Any((p) => p.Name.Contains("IS"));
////Console.WriteLine($"{nameof(isThereAnyNameContainsIS)} ? {isThereAnyNameContainsIS}");

////bool isThereAnyNameContainsIT = context.Products.Any((p) => p.Name.Contains("IT"));
////Console.WriteLine($"{nameof(isThereAnyNameContainsIT)} ? {isThereAnyNameContainsIT}");

////Console.WriteLine($"Count of products: {context.Products.Count()}");
////Console.WriteLine($"Count of products That Contains IS: {context.Products.Count((p)=>p.Name.Contains("IS"))}");
////Console.WriteLine($"Count of products That Contains IT: {context.Products.Count((p)=>p.Name.Contains("IT"))}");

////Console.WriteLine($"Sum of Prices: {context.Products.Sum(p=>p.Price)}");
////Console.WriteLine($"Average of Prices: {context.Products.Average(p=>p.Price)}");
////Console.WriteLine($"Max of Prices: {context.Products.Max(p=>p.Price)}");
////Console.WriteLine($"Min of Prices: {context.Products.Min(p=>p.Price)}");


//context.Database.ExecuteSqlRaw("insert into Products values('CRM', 'Customer Relationship Management', 425000)");
//Console.WriteLine("New product added/inserted successfully.");

using BrightStars.Data;

AppDbContext context = new AppDbContext();
var productsGroupedByPrice = context.Products.GroupBy(p => p.Price);

foreach (var group in productsGroupedByPrice)
{
    Console.WriteLine("\n" + group.Key + ":");
    foreach (var product in group)
    {
        Console.WriteLine(
            $"Id: {product.Id} - Name: {product.Name} - Notes: {product.Notes} - Price: {product.Price}");
    }
}
