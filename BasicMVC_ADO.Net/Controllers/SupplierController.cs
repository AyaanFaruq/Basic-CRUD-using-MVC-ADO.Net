using BasicMVC_ADO.Net.Gateway;
using BasicMVC_ADO.Net.Models;
using System.Web.Mvc;

namespace BasicMVC_ADO.Net.Controllers
{
    public class SupplierController : Controller
    {
        SupplierGateway aSupplierGateway = new SupplierGateway();
        // GET: Supplier
        public ActionResult Index()
        {

            ModelState.Clear();

            return View(aSupplierGateway.GetAllSuppliers());
        }


        public ActionResult AddSupplier()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSupplier(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                aSupplierGateway.AddSupplier(supplier);


            }

            return RedirectToAction("Index");
        }

        public ActionResult EditSupplier(int id)
        {
            return View(aSupplierGateway.GetAllSuppliers().Find(s => s.Id == id));
        }

        [HttpPost]
        public ActionResult EditSupplier(int id, Supplier supplier)
        {
            aSupplierGateway.UpdateSupplier(supplier);
            return RedirectToAction("Index");

        }

        public ActionResult DeleteSupplier(int id)
        {
            aSupplierGateway.DeleteSupplier(id);

            return RedirectToAction("Index");
        }

    }
}