using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Game.Web
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void lkbtnMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member.aspx");
        }

        protected void lkbtnMonster_Click(object sender, EventArgs e)
        {
            Response.Redirect("Monster.aspx");
        }

        protected void lkbtnItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("Item.aspx");
        }
        protected void lkbtnTreasure_Click(object sender, EventArgs e)
        {
            Response.Redirect("Treasure.aspx");
        }
    }
}