using System;
using System.Threading.Tasks;
using Orleans;
using SelfStorageCore.Grains.User.Interfaces;

namespace SelfStorageCore.Grains.User
{
    public class UserGrain : Grain, IUserGrain
    {
    }
}