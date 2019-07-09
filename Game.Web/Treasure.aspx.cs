using Game.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.Web
{
    public partial class Treasure : System.Web.UI.Page
    {
        TreasureService treasureService;
        protected void Page_Load(object sender, EventArgs e)
        {
            treasureService = new TreasureService();
            List<Common.Entities.Treasure> list = treasureService.GetAll().ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}