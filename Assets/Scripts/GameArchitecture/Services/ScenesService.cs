using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameArchitecture {

  [CreateAssetMenu(fileName = "SceneService", menuName = "GameArchitecture/Services/SceneService")]
  public class SceneService: Service {
    [SerializeField] SceneConfig[] sceneConfigs;

    public override async UniTask InitializeAsync() {
      Debug.Log("Scene Service Initialized");
      await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

    public override async UniTask ShutdownAsync() {
      Debug.Log("Scene Service Shutdown");
      await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

    public void LoadScene(SceneConfig config) {
      LoadSceneAsync(config).Forget();
    }

    public async UniTask LoadSceneAsync(SceneConfig config) {
      Debug.Log($"<color=#00FFFF>Begin loading scene: [{config.name}]...</color>");

      AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(config.name);
      await asyncLoad.ToUniTask();

      await UniTask.DelayFrame(1); // Симуляция асинхронной задачи

      Debug.Log($"<color=#00FFFF>Scene: [{config.name}] loaded.</color>");
    }
  }
}
