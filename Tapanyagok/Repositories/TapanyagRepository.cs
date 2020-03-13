using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapanyagok.Models;

namespace Tapanyagok.Repositories
{
    class TapanyagRepository :IDisposable
    {
        tapanyagokContext db = new tapanyagokContext();
        private int _totalItems;

        public BindingList<tapanyag> GetAllTapanyag(int page = 0, int itemsPerPage = 0, string search = null, string sortBy = null, bool ascending = true)
        {

            //SQL query-ként kezeli
            IQueryable<tapanyag> query = db.tapanyag.OrderBy(x => x.id).AsQueryable();

            //Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {

                search = search.ToLower();

                query = query.Where(x =>
                    x.nev.ToLower().Contains(search)                     
                );
            }

            //Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.id) : query.OrderByDescending(x => x.id);
                        break;
                    case "nev":
                        query = ascending ? query.OrderBy(x => x.nev) : query.OrderByDescending(x => x.nev);
                        break;
                    case "energia":
                        query = ascending ? query.OrderBy(x => x.energia) : query.OrderByDescending(x => x.energia);
                        break;
                    case "feherje":
                        query = ascending ? query.OrderBy(x => x.feherje) : query.OrderByDescending(x => x.feherje);
                        break;
                    case "zsir":
                        query = ascending ? query.OrderBy(x => x.zsir) : query.OrderByDescending(x => x.zsir);
                        break;
                    case "szenhidrat":
                        query = ascending ? query.OrderBy(x => x.szenhidrat) : query.OrderByDescending(x => x.szenhidrat);
                        break;

                }
            }

            //Összes találat
            _totalItems = query.Count();

            //Oldaltördelés
            if (page + itemsPerPage > 0)
            {
                // skip = ugrás a megadott számú elemre
                // take = hátralévő mennyiséget kiveszi (jelenítse meg)
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);

            }

            return new BindingList<tapanyag>(query.ToList());
        }

        public tapanyag GetTapanyag(int id) 
        {
            return db.tapanyag.FirstOrDefault(r => r.id == id);
        }

        public bool Exists(tapanyag item) 
        {
            tapanyag temp = db.tapanyag.FirstOrDefault(r => r.id == item.id);
            return temp != null ? true : false;
        }

        public void Insert(tapanyag item) 
        {
            db.tapanyag.Add(item);
           
        }

        public void Update(tapanyag item) 
        {
            tapanyag temp = db.tapanyag.Find(item.id);
            if (temp != null)
            {
                db.Entry(temp).CurrentValues.SetValues(item);
            }            
        }

        public void Delete(tapanyag item)
        {            
            db.tapanyag.Remove(item);           
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }
    }
}
