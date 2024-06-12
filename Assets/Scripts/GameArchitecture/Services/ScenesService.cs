using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  [CreateAssetMenu(fileName = "ScenesService", menuName = "GameArchitecture/Services/ScenesService")]
  public class ScenesService: Service {
    [SerializeField] SceneConfig[] sceneConfigs;

    public override async UniTask InitializeAsync() {
        Debug.Log("Scenes Service Initialized");
        await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

    public override async UniTask ShutdownAsync() {
        Debug.Log("Scenes Service Shutdown");
        await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

  }
}
