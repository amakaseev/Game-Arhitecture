using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  public abstract class GameManager: ScriptableObject {
    public ServicesManager servicesManager;

    public virtual async UniTask InitializeAsync() {
      if (servicesManager != null) {
        await servicesManager.InitializeAsync();
      }
    }

    public virtual async UniTask ShutdownAsync() {
      if (servicesManager != null) {
        await servicesManager.ShutdownAsync();
      }
    }
  }

}
