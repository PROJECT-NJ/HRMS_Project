using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMS_Project.Models.MenuItem;
using Microsoft.Extensions.Options;

namespace HRMS_Project.Components
{

    public class Menu : ViewComponent
    {

        private readonly MenuItemViewModel _menu;

        public Menu(IOptions<MenuItemViewModel> menu)
        {
            _menu = menu.Value;
        }

        public IViewComponentResult Invoke()
        {
            //MenuItemViewModel _MenuItemViewModel = new MenuItemViewModel
            //{

            //    Link = "test1",
            //    LinkName = "test2"

            //};
            MenuItemViewModel _MenuItemViewModel = new MenuItemViewModel();
            List<Detail_SideMenu> List_Detail_SideMenu = new List<Detail_SideMenu>();
            List<Detail_SideMenu_Node> List_Detail_SideMenu_Node = new List<Detail_SideMenu_Node>();

            //add home
            List_Detail_SideMenu_Node.Add(new Detail_SideMenu_Node
            {

                Name = "Home",
                ControlName = "Employee",
                ActionName = "Home"
            });

            List_Detail_SideMenu.Add(new Detail_SideMenu
            {
                Name="Home",
                detail_sideMenu_node = List_Detail_SideMenu_Node
            });
            List_Detail_SideMenu_Node = new List<Detail_SideMenu_Node>();
            //add home

            //add request
            List_Detail_SideMenu_Node.Add(new Detail_SideMenu_Node
            {
                Name = "OT",
                ControlName = "Employee",
                ActionName = "OT"
            });

            List_Detail_SideMenu_Node.Add(new Detail_SideMenu_Node
            {
                Name = "Leave/Time Verification",
                ControlName = "Employee",
                ActionName = "Leave"
            });

            List_Detail_SideMenu.Add(new Detail_SideMenu
            {
                Name = "Request",
                detail_sideMenu_node = List_Detail_SideMenu_Node
            });

            List_Detail_SideMenu_Node = new List<Detail_SideMenu_Node>();

            //add request


            //add TimeSheet
            List_Detail_SideMenu_Node.Add(new Detail_SideMenu_Node
            {

                Name = "TimeSheet",
                ControlName = "Employee",
                ActionName = "TimeSheet"
            });

            List_Detail_SideMenu.Add(new Detail_SideMenu
            {
                Name = "TimeSheet",
                detail_sideMenu_node = List_Detail_SideMenu_Node
            });

            List_Detail_SideMenu_Node = new List<Detail_SideMenu_Node>();
            //add TimeSheet



            _MenuItemViewModel.name_side_menu = "Jaruwith";

            _MenuItemViewModel.detail_sideMenu = List_Detail_SideMenu;


            return View(_MenuItemViewModel);
        }

    }
}
