using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapanyagok.Models;

namespace Tapanyagok.ViewInterfaces
{
    interface ITapanyagView : ITablazatView<tapanyag>
    {
        List<tapanyag> tapanyag { get; set; }
    }
}
