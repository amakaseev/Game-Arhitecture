using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  [CreateAssetMenu(fileName = "ServicesManager", menuName = "GameArchitecture/Services/ServicesManager")]
  public class ServicesManager: ScriptableObject {
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

    public T GetService<T>() where T: Service {
      if (services == null) return null;

      foreach (var service in services) {
        if (service is T) {
          return (T)service;
        }
      }
      return null;
    }
  }

}