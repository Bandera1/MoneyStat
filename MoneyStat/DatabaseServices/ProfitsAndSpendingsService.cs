using MoneyStat.EnititiesClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyStat.DatabaseServices
{
    class ProfitsAndSpendingsService
    {
        DatabaseContext db = new DatabaseContext();

        public List<ProfitsAndSpendings> GetAllMoneyNodes(Func<ProfitsAndSpendings, object> SortKey,string Type = null)
        {
            if (Type != null)
                return db.ProfitsAndSpendings.AsNoTracking().Where( x => x.Type.Name == Type).OrderBy(SortKey).ToList();

            return db.ProfitsAndSpendings.AsNoTracking().OrderBy(SortKey).ToList();
        }

        public void AddNewMoneyNode(ProfitsAndSpendings Node)
        {
            if (Node == null)
                return;

            db.ProfitsAndSpendings.Add(Node);

            db.SaveChanges();
        }

        public bool AddCategory(Categories category)
        {
            if (category == null)
                return false;

            foreach (var c in db.Categories.AsNoTracking().ToList())
            {
                if (c.Name == category.Name)
                    return false;
            }


            db.Categories.Add(category);

            db.SaveChanges();

            return true;
        }

        public List<Categories> GetCategories()
        {
            return db.Categories.AsNoTracking().ToList();
        }
    }
}
