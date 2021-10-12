using System.Collections.Generic;
using Model;
namespace FileData
{
    public interface IFamilyService
    {
        public IList<Family> GetFamilies();
        public void AddFamily(Family family);
        public void EditFamily(Family family);
        public void RemoveFamily(Family family);
    }
}