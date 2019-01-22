using System.Threading.Tasks;
using Orleans;
using SelfStorageCore.Models.User;

namespace SelfStorageCore.Grains.User.Interfaces
{
    public interface IUserGrain : IGrainWithGuidKey
    {
//        Task<UserInfo> GetInfo();
//        Task UpdateInfo(UserInfo info);
    }
}