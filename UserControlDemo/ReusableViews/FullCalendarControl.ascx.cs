using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlDemo
{
    public partial class FullCalendarControl : System.Web.UI.UserControl
    {
        //private string displayText;

        //public string DisplayText
        //{
        //    get { return displayText; }
        //    set { lblDisplayText.Text = value; }
        //}


        //public DateTime SelectedDate
        //{
        //    get
        //    {

        //        return string.IsNullOrEmpty(txtDate.Text) ? DateTime.Today.Date : Convert.ToDateTime(txtDate.Text);
        //    }
        //    set
        //    {
        //        txtDate.Text = value.ToString();
        //    }
        //}

        //private bool disableFutureDates;

        //public bool DisableFutureDates
        //{
        //    set { disableFutureDates = value; }
        //}


        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    calDate.SelectedDate = DateTime.Now;
            //}
        }

        //protected void calDate_DayRender(object sender, DayRenderEventArgs e)
        //{

        //    if (disableFutureDates & e.Day.Date > DateTime.Now)
        //        e.Day.IsSelectable = false;
        //}
        protected void imgBtnCalender_Click(object sender, ImageClickEventArgs e)
        {
            calDate.Visible = !calDate.Visible;
        }

        protected void calDate_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = calDate.SelectedDate.ToString("yyyy-MM-dd");// +" " + DateTime.Now.ToString("HH:mm:ss");
            calDate.Visible = false;
            //var dateSelectedEventData = new DateSelectedEventArgs(calDate.SelectedDate);
            //if (DateSelected != null)
                //DateSelected(this, dateSelectedEventData);
        }
        //public event DateSelectedEventHandler DateSelected;
    }
}