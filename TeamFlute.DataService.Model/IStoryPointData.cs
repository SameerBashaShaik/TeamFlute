using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TeamFlute.DataService.Model
{
    public interface IStoryPointData
    {
        Task AddStoryPointData(AssociateStoryPointData perStoryData);

        Task UpdateStoryPointData(Guid storyPointIdtoUpdate, AssociateStoryPointData perStoryData);

        Task<AssociateStoryPointData> GetStoryPointData(Guid storypointEntryId);

        Task<IEnumerable<AssociateStoryPointData>> GetAllStoryPointData();

        Task DeleteStoryPointEntry(Guid entryId);

        Task DeleteAllStoryPointEntries();

        Task AddAssociateInteractionData(AssociateInteractionData associateInteractionData);

        Task<IEnumerable<AssociateInteractionData>> GetAssociateInteractionData(string associate);

        Task<IEnumerable<AssociateInteractionData>> GetAllAssociateInteractionData();

        Task DeleteAllAssociateInteractionEntries();

    }
}
