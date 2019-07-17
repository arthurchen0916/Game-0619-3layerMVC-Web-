using Game.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Game.Web
{
    public partial class Item : System.Web.UI.Page
    {
        ItemService itemService;
        protected void Page_Load(object sender, EventArgs e)
        {
            Binding();
        }

        protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "edit")
            {

            }
            else if (e.CommandName == "del")
            {
                var id = GridView1.Rows[int.Parse(e.CommandArgument.ToString())].Cells[4].Text;
                if (id == null)
                {
                    e.Handled = false;
                }
                itemService = new ItemService();
                var chk = itemService.Remove(Convert.ToInt32(id));
                if (chk)
                {
                    Binding();
                }
                else
                {
                    // fail
                }
            }
        }

        private void Binding()
        {
            itemService = new ItemService();
            List<Common.Entities.Item> list = itemService.GetAll().ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}