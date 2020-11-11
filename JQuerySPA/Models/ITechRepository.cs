using System.Collections.Generic;

namespace API_DB.Models
{
    public interface ITechRepository
    {
        List<Tech> GetTechs();
        void AddTech(Tech model);
        void UpdateData(Tech model);
        void DeleteData(Tech model);
    }
}
