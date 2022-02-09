using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_EntityFramework_Integration
{
    public partial class RetrivalPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentContext sContext = new StudentContext();
            var query = from s in sContext.students
                        orderby s.Name select s;
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
    }
}