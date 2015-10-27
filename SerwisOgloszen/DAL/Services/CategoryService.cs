using DAL.ViewModel;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public  class CategoryService
    {

        public List<KategoriaViewModel> GetAllCategory()
        {
            var context = new hEntities();
            var category = context.Kategoria.GroupBy(z => z.Nazwa).Select(grp => grp.ToList()).ToList();

            List<KategoriaViewModel> list = new List<KategoriaViewModel>();
            foreach (var item in category)
            {
               
                list.Add( new KategoriaViewModel { Id=item[0].Id , Nazwa=item[0].Nazwa , IdParent=item[0].Id_Parent, MainParent=item[0].Main_Parent} );
            }

            list = list.OrderBy(x => x.Id).ToList();
            return list ;

            
        }

        //public List<Kategoria> GetCategoryForItem(PrzemiotViewModel item)
        //{
        //    var context = new hEntities();
        //    var list = context.Kategoria.Where(x => item.Id_Kategoria == x.Id).ToList();
        //    return list;


        //}
    }
}
