using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TeamFlute.DataService.Model
{
    public interface IDataService : IService
    {
        Task<AssociateStoryPointData[]> GetAllStoryPointDataAsync();

        Task AddStoryPointsAsync(AssociateStoryPointData perStoryData);

        Task UpdateStoryPointsAsync(Guid storyPointIdtoUpdate, AssociateStoryPointData perStoryData);

        Task<AssociateStoryPointData> GetStoryPointDataAsync(Guid storypointEntryId);

        Task DeleteStoryPointEntryAsync(Guid entryId);

        Task DeleteAllStoryPointDataAsync();

        #region Interaction Data

        Task AddAssociateInteractionDataAsync(AssociateInteractionData AssociateInteractionData);

        Task<AssociateInteractionData[]> GetInteractionDataAsync(string associate);

        Task<AssociateInteractionData[]> GetAllInteractionDataAsync();

        Task DeleteAllAssociateInteractionDataAsync();


        #endregion


    }
}
