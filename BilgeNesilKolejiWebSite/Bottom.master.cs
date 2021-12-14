using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bottom : System.Web.UI.MasterPage
{
    protected List<cMenu> menuList;
    protected List<cMenu> subMenuList;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            menuList = cMenu.GetMenuByTopId(0);
            string menuText = "";

            menuText += "<ul id=\"accordion\" class=\"nav navbar-nav navbar-right panel-group\">";

            foreach (var item in menuList)
            {
                if (item.BottomCount == 0)
                {
                    menuText += "<li class=\"panel\">";
                    menuText += "<a href=\"" + item.Link + "\" class=\"collapsed\">" + item.MenuName + "</a>";
                    menuText += "</li>";
                }
                else
                {
                    subMenuList = cMenu.GetMenuByTopId(item.Id);

                    menuText += "<li class=\"dropdown panel simple-dropdown\">";
                    menuText += "<a href=\"" + item.Link + "\" class=\"dropdown-toggle collapsed\" data-hover=\"dropdown\">" + item.MenuName + " <i class=\"fa fa-angle-down\"></i></a>";
                    menuText += "<ul id=\"collapse7\" class=\"dropdown-menu panel-collapse collapse\" role=\"menu\">";

                    foreach (var subItem in subMenuList)
                    {
                        menuText += "<li><a href=\"" + subItem.Link + "\">" + subItem.MenuName + "</a></li>";
                    }

                    menuText += "</ul>";
                    menuText += "</li>";
                }
            }

            menuText += "</ul>";

            ltrMenu.Text = menuText;
        }
    }
}
