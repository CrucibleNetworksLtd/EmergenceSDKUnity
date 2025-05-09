﻿using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using EmergenceSDK.Runtime.Services;
using EmergenceSDK.Runtime.Types;
using EmergenceSDK.Runtime.Types.Delegates;
using EmergenceSDK.Runtime.Types.Inventory;

namespace EmergenceSDK.Runtime.Futureverse.Services
{
    public interface IFutureverseInventoryService: IInventoryService
    {
        /// <summary>
        /// Attempts to Retrieve a list of NFT's owned by the currently connected wallet within the provided collections
        /// </summary>
        /// <param name="collectionIds">Collections to use as Filter for inventory response</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="InventoryItem"/>s wrapped within a <see cref="ServiceResponse{T}"/></returns>
        UniTask<ServiceResponse<List<InventoryItem>>> InventoryByOwnerAndCollectionAsync(List<string> collectionIds);
        
        /// <summary>
        /// Attempts to Retrieve a list of NFT's owned by the currently connected wallet within the provided collections. Callbacks are called when complete
        /// </summary>
        /// <param name="collectionIds">List of collections to use as a filter for the inventory response</param>
        /// <param name="success">Callback method triggered on successful get inventory. Must take List<InventoryItem></param>
        /// <param name="errorCallback">Callback method triggered on error during operation. Must accept String: message and long: code</param>
        UniTask InventoryByOwnerAndCollection(List<string> collectionIds, SuccessInventoryByOwner success, ErrorCallback errorCallback);
    }
}