using System.Threading.Tasks;
using Orleans;
using SelfStorageCore.Models.User;

namespace SelfStorageCore.Grains.User.Interfaces
{
    public interface IUserInfoGrain : IGrainWithGuidKey
    {
//        Task<UserInfo> GetInfo();
    }
}