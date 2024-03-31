using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B20
{
    public partial class Pregled : System.Web.UI.Page
    {

        ServiceReference1.WebService1SoapClient servis = new ServiceReference1.WebService1SoapClient();


        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                DropDownList1.DataSource = servis.ProcitajSveValute();
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime izabraniDatum = Calendar1.SelectedDate;
            string oznakaValute = DropDownList1.SelectedValue;
            double kurs = servis.ProcitajKursNaDan(izabraniDatum, oznakaValute);
            if (kurs != 0)
                Label3.Text = "Kurs na dan: " + kurs;
            else
                Label3.Text = "Ne postoji trazeni podatak!";
        }
    }
}