


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

// ProductTest();

// CategoryTest();

   ProductDtoTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());


    foreach (var product in productManager.GetAllByUnitPrice(50, 100))
    {

        Console.WriteLine(product.ProductName);

    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());


    foreach (var category in categoryManager.GetAll())
    {

        Console.WriteLine(category.CategoryName);

    }
}

static void ProductDtoTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());


    foreach (var product in productManager.GetProductDetails())
    {

        
        Console.WriteLine(" Product Name: "+product.ProductName + " --> " +" Category Name: "+ product.CategoryName + " --> " +" Units In Stock: " +product.UnitsInStock);

    }
}