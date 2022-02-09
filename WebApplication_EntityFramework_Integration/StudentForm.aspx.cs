using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication_EntityFramework_Integration.Models;

namespace WebApplication_EntityFramework_Integration
{
    public partial class StudentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentContext sContext = new StudentContext();
            var stud = new Student()
            {
                ID = Convert.ToInt32(txtID.Text),
                Name = txtName.Text,
                Course = txtCourse.Text,
                Fee = Convert.ToDouble(txtFee.Text),
            };
            sContext.students.Add(stud);
            sContext.SaveChanges();
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            Response.Redirect("RetrivalPage.aspx");
        }
    }
}
    
