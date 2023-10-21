﻿using BetWalletApi.Models.Common;

namespace BetWalletApi.Models.Wallets
{
    public interface IWalletRepository : IRepository<Wallet>
    {
        Task<Wallet> FindByUserIdAsync(Guid userId);
    }
}
