using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BBBMVCPROJECT.Models;



namespace BBBMVCPROJECT
{
    public interface IGadgetRepository
    {
        public IEnumerable<Gadget> GetAllGadgets();
        public Gadget GetGadget(int id);

        public void UpdateGadget(Gadget gadget);


        public void InsertGadget(Gadget gadgetToInsert);

        public IEnumerable<Category> GetAllCategories();

        public ProductHeaderValue AssignCategory();

        public void DeleteGadget(Gadget gadget);
    }










}
