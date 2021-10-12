using System.Collections.Generic;
using System.Linq;
using Model;
namespace FileData
{
    public class AdultService : IAdultService
    {
        private FileContext fileContext = new FileContext();

        public IList<Adult> GetAdults()
        {
            return fileContext.Adults;
        }
        public void AddAdult(Adult adult)
        {
            fileContext.Adults.Add(adult);
            fileContext.SaveChanges();
        }

        public void EditAdult(Adult adult)
        {
            fileContext.Adults.Where(ad => ad.Id == adult.Id).Select(ad => ad = adult);
            fileContext.SaveChanges();
        }

        public void RemoveAdult(Adult adult)
        {
            fileContext.Adults.Remove(adult);
            fileContext.SaveChanges();
        }
    }
}