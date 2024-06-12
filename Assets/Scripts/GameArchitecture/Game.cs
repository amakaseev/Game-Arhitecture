using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  public abstract class Game: ScriptableObject {
    [SerializeField] ServiceContainer serviceContainer;

    public virtual async UniTask InitializeAsync() {
      if (serviceContainer != null) {
        await serviceContainer.InitializeAsync();
      }
    }

    public virtual async UniTask ShutdownAsync() {
      if (serviceContainer != null) {
        await serviceContainer.ShutdownAsync();
      }
    }

    public abstract UniTask Start();

    protected T GetService<T>() where T: Service {
      return serviceContainer.GetService<T>();
    }
  }

}
