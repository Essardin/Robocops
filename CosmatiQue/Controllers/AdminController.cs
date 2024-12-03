using CosmatiQue.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace CosmatiQue.Controllers
{
    public class AdminController : Controller
    {
        private readonly IMongoCollection<ProductsModel> _productsCollection;

        public AdminController(IConfiguration configuration)
        {
            
           
            var mongoClient = new MongoClient(configuration.GetSection("MongoDB")["ConnectionString"]);
            var database = mongoClient.GetDatabase(configuration.GetSection("MongoDB")["DatabaseName"]);
            _productsCollection = database.GetCollection<ProductsModel>("Products");
    
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            List<ProductsModel> products = _productsCollection.Find(static _ => true).ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductsModel model)
        {
            if (ModelState.IsValid)
            {
                
            _productsCollection.InsertOne(model);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditProduct()
        {
            return View();
        }
    }
}
