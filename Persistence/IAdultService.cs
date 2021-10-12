using System.Collections.Generic;
using Model;
namespace FileData
{
    public interface IAdultService
    {
        public IList<Adult> GetAdults();
        public void AddAdult(Adult adult);
        public void EditAdult(Adult adult);
        public void RemoveAdult(Adult adult);
    }
}