﻿using Core.Puertto.DTOs.General;

namespace PuerttoAPI.Interfaces
{
    public interface IGeneralServices
    {
        Task<List<BannerIndex>> GetBannerByIndex(bool isSingIn);

        Task<List<BannerIndex>> GetBannerCruzIndex();

    }
}
