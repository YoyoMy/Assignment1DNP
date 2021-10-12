using System.Collections.Generic;
using System.Linq;
using Model;
namespace FileData
{
    public class FamilyService : IFamilyService
    {
        private FileContext fileContext = new FileContext();
        public void AddFamily(Family family)
        {
            fileContext.Families.Add(family);
            fileContext.SaveChanges();
        }

        public void EditFamily(Family family)
        {
            fileContext.Families.Where(f => f.Id == family.Id).Select(f => f = family);
            fileContext.SaveChanges();
        }

        public IList<Family> GetFamilies()
        {
            return fileContext.Families;
        }

        public void RemoveFamily(Family family)
        {
            fileContext.Families.Remove(family);
            fileContext.SaveChanges();
        }
    }
}