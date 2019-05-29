using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EF_CRUDAPP
{
    public partial class Default : System.Web.UI.Page
    {
        Crud cs = new Crud();
        EFDBEntities Db = new EFDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvCustomer.DataSource = Db.Customers.ToList();
            gvCustomer.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            cs.Customer_add(txtFirstName.Text, txtLastName.Text, txtCity.Text, txtAddress.Text);
            gvCustomer.DataSource = Db.Customers.ToList();
            gvCustomer.DataBind();
            Response.Redirect("Default.aspx");
        }
    }
}