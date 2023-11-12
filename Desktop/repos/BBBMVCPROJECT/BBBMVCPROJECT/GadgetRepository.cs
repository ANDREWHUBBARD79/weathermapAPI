using BBBMVCPROJECT.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;



namespace BBBMVCPROJECT
{
    public class GadgetRepository
    {
        private readonly IDbConnection _conn;
        public GadgetRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Models.Gadget> GetAllGadgets()
        {
            return _conn.Query<Models.Gadget>("Select * From gadgets");
        }

        public Gadget GetGadget(int id)
        {
            return _conn.QuerySingle<Gadget>("SELECT * FROM GADGETS WHERE GADGETID = @id",
                new { id = id });
        }

        public void UpdateGadget(Gadget gadget)
        {
            _conn.Execute("UPDATE gadgets SET NAME = @name, Price = @price WHERE GadgetID = @id",
                new
                {
                    name = gadget.Name,
                    price = gadget.Price,
                    id = gadget.GadgetID
                });


        }

        public void InsertGadget(Gadget gadgetToInsert)
        {
            _conn.Execute("INSERT INTO products (NAME, PRICE, CATEGORYID) VALUES (@name, @price, @categoryID);",
                new { name = gadgetToInsert.Name, price = gadgetToInsert.Price, categoryID = gadgetToInsert.CategoryID });
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM categories;");
        }

        public Gadget AssignCategory()
        {
            var categoryList = GetCategories();
            var product = new Gadget();
            product.Categories = categoryList;
            return product;
        }

        public void DeleteGadget(Gadget gadget)
        {
            _conn.Execute("DELETE FROM REVIEWS WHERE GadgetID = @id;", new { id = gadget.GadgetID });
            _conn.Execute("DELETE FROM Sales WHERE ProductID = @id;", new { id = gadget.GadgetID });
            _conn.Execute("DELETE FROM Products WHERE ProductID = @id;", new { id = gadget.GadgetID });
        }





    }
}
