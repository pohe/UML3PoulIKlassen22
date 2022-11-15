using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Poul
{
    public class MenuCatalog : IMenuCatalog
    {
        List<IMenuItem> _menuItems;

        public MenuCatalog()
        {
            _menuItems = new List<IMenuItem>(); 
        }
        public int Count
        {
            get { return _menuItems.Count; }
        }

        public void Add(IMenuItem aMenuItem)
        {
            _menuItems.Add(aMenuItem);
        }

        public void Delete(int number)
        {
            throw new NotImplementedException();
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            throw new NotImplementedException();
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            throw new NotImplementedException();
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            throw new NotImplementedException();
        }

        public void PrintBeveragesMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintPizzasMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintToppingsMenu()
        {
            throw new NotImplementedException();
        }

        public IMenuItem Search(int number)
        {
            throw new NotImplementedException();
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            throw new NotImplementedException();
        }
    }
}
