using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  public abstract class ServicesManager: ScriptableObject {
    public Service[] services;

    public async UniTask InitializeAsync() {
      foreach (var service in services) {
        await service.InitializeAsync();
      }
    }

    public async UniTask ShutdownAsync() {
      foreach (var service in services) {
        await service.ShutdownAsync();
      }
    }
  }

}