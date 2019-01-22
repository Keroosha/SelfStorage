using System.Threading.Tasks;
using SelfStorageCore.Grains.User.Interfaces;
using SelfStorageCore.Models.User;

namespace SelfStorageCore.Grains.User
{
    public class UserInfoGrain : IUserGrain
    {
        private readonly IUserGrain _userGrain;

        public async Task<UserInfo> GetInfo()
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateInfo(UserInfo info)
        {
            throw new System.NotImplementedException();
        }
    }
}