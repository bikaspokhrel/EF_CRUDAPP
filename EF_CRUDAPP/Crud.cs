using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_CRUDAPP
{
    public class Crud
    {
        EFDBEntities context = new EFDBEntities();
        EFDBEntities Db = new EFDBEntities();
        Customer crud = new Customer();

        public void Customer_add(string Firstname, string Lastname, string City, string Address)
        {
            crud.FirstName = Firstname;
            crud.LastName = Lastname;
            crud.City = City;
            crud.Address = Address;
            context.Customers.Add(crud);
            context.SaveChanges();
        }
    }
}