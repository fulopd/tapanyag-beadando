using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapanyagok.Models;
using Tapanyagok.Repositories;
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Presenters
{
    class TablazatPresenter
    {
        private ITablazatView view;
        private TapanyagRepository repo = new TapanyagRepository();

        public TablazatPresenter(ITablazatView param)
        {
            view = param;
        }

        public void LoadData() 
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

        public void Add(tapanyag param)
        {
            view.bindingList.Add(param);
            // hozzáadás ehhez a contexthez is
            repo.Insert(param);
        }


        public void Modify(int listIndex, tapanyag param)
        {
            //TODO: A Modify metódushoz egy index és egy tapanyag típusú paraméter 
            //fog kellene. Az index alapján a listában lehet kikeresni az elemet és 
            //frissíteni a nézetben, majd a repository-nak átadni.
            repo.Update(param);
        }

        public void Remove(int index)
        {
            var tapa = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (tapa.id > 0)
            {
                repo.Delete(tapa);
            }
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
