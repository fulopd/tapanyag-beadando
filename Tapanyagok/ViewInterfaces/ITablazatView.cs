using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapanyagok.Models;

namespace Tapanyagok.ViewInterfaces
{
    interface ITablazatView
    {
        //Oda vissza kapcsolat az adatbázis és a DataGridview között
        BindingList<tapanyag> bindingList { get; set; } //kapcsolad BindingList -nél oda vissza működik (modosítások adatbázisban mentődnek)
        int pageNumber { get; set; }
        int itemsPerPage { get; set; }
        string search { get; }
        string sortBy { get; set; }
        bool ascending { get; set; }
        int totalitems { set; }
    }
}
