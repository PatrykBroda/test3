﻿using PolymindGames.InventorySystem;
using UnityEngine;
using UnityEngine.Events;

namespace PolymindGames
{
    public interface ICharacter
    {
        bool IsInitialized { get; }

        Transform ViewTransform { get; }
        Collider[] Colliders { get; }
        
        IAudioPlayer AudioPlayer { get; }
        IHealthManager HealthManager { get; }
        IInventory Inventory { get; }

        event UnityAction Initialized;

        void StateEnterCallback(MovementStateType state);

        bool TryGetModule<T>(out T module) where T : class, ICharacterModule;
        void GetModule<T>(out T module) where T : class, ICharacterModule;
        T GetModule<T>() where T : class, ICharacterModule;

        bool HasCollider(Collider collider);

        #region Monobehaviour
        GameObject gameObject { get; }
        Transform transform { get; }
        #endregion
    }
}