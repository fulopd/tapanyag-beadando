using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapanyagok.Models;
using Tapanyagok.Repositories;
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Presenters
{
    class TapanyagPresenter
    {
        private ITapanyagView view;
        private TapanyagRepository repo = new TapanyagRepository();

        public TapanyagPresenter(ITapanyagView param)
        {
            view = param;
        }

        public void loadData() 
        {
            view.bindingList = repo.GetAllTapanyag(
                view.pageNumber,
                view.itemsPerPage,
                view.search,
                view.sortBy,
                view.ascending
                );

            view.totalitems = repo.Count();
        }

        public void delete(tapanyag item) 
        {
            repo.delete(item);
        }

    }
}
