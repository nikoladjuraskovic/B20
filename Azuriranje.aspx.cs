using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B20
{
    public partial class Azuriranje : System.Web.UI.Page
    {

        localhost.WebService1 servis;
        protected void Page_Load(object sender, EventArgs e)
        {
            servis = new localhost.WebService1();
            if (!IsPostBack)
            {
                DropDownList1.DataSource = servis.ProcitajSveValute();
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime datum = Calendar1.SelectedDate;
            string oznaka = DropDownList1.SelectedValue;
            double kurs = double.Parse(TextBox1.Text);

            bool rez = servis.UpisiKursNaDan(datum, oznaka, kurs);
        }
    }
}