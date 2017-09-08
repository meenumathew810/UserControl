using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlDemo
{
    public partial class DobView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imgBtnCalender_Click(object sender, ImageClickEventArgs e)
        {
            calDate.Visible = !calDate.Visible;
        }
        protected void calDate_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = calDate.SelectedDate.ToString("MM-dd-yyy");
            calDate.Visible = false;
        }
    }
}