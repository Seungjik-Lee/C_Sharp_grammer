using ClassTest2_1.Controll;
using ClassTest2_1.Model;
using ClassTest2_1.Util;
using ClassTest2_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            UnionController uHandler = new UnionController(new RandData());



            while (true)
            {
                switch (menu.mainMenu())
                {
                    case Menu.MENU_MAIN_RAND:
                        //uHandler.CarHandle.insRandData(menu.getRandSize());
                        //uHandler.CustHandle.insRandData(menu.getRandSize());
                        //uHandler.SellHandle.insRandData(menu.getRandSize());
                        uHandler.insRandData(menu.getRandSize());
                        break;
                    case Menu.MENU_MAIN_DEL_ALL:
                        uHandler.CarHandle.removeAll();
                        uHandler.CustHandle.removeAll();
                        uHandler.SellHandle.removeAll();
                        break;
                    case Menu.MENU_MAIN_VIEW:
                        //uHandler.CarHandle.carView();
                        //uHandler.CustHandle.custView();
                        //uHandler.SellHandle.sellView();
                        uHandler.dealViewAll();
                        break;
                    case Menu.MENU_MAIN_ADD:
                        switch (menu.subAddMenu())
                        {
                            case Menu.MENU_SUB_ADD_CAR:
                                uHandler.CarHandle.addCarItem(menu.addCarMenu2());
                                break;
                            case Menu.MENU_SUB_ADD_CUST:
                                uHandler.CustHandle.addCustItem(menu.addCustMenu2());
                                break;
                            case Menu.MENU_SUB_ADD_SELL:
                                uHandler.SellHandle.addSellItem(menu.addSellMenu2());
                                break;
                            case Menu.MENU_SUB_ADD_EXIT:
                                break;
                        }
                        break;
                    case Menu.MENU_MAIN_DEL:
                        switch (menu.subDelMenu())
                        {
                            case Menu.MENU_SUB_ADD_CAR:
                                uHandler.CarHandle.delCarItem(menu.delCarMenu());
                                break;
                            case Menu.MENU_SUB_ADD_CUST:
                                uHandler.CustHandle.delCustItem(menu.delCustMenu());
                                break;
                            case Menu.MENU_SUB_ADD_SELL:
                                uHandler.SellHandle.delSellItem(menu.delSellMenu());
                                break;
                            case Menu.MENU_SUB_ADD_EXIT:
                                break;
                        }
                        break;
                    case Menu.MENU_MAIN_UPDATE:

                        switch (menu.subUpdateMenu())
                        {
                            case Menu.MENU_SUB_ADD_CAR:
                                uHandler.CarHandle.updateCarItem(menu.updateCarMenu());
                                break;
                            case Menu.MENU_SUB_ADD_CUST:
                                uHandler.CustHandle.updateCustItem(menu.updateCustMenu());
                                break;
                            case Menu.MENU_SUB_ADD_SELL:
                                uHandler.SellHandle.updateSellItem(menu.updateSellMenu());
                                break;
                            case Menu.MENU_SUB_ADD_EXIT:
                                break;
                        }
                        break;
                    case Menu.MENU_MAIN_EXIT:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
