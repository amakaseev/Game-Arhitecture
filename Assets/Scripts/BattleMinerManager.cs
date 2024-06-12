using Cysharp.Threading.Tasks;
using GameArchitecture;
using UnityEngine;

namespace BattleMiner
{
  [CreateAssetMenu(fileName = "BattleMinerManager", menuName = "BattleMinerManager")]
  public class BattleMinerManager: GameManager {
    [SerializeField] SceneConfig firstScene;

    public override async UniTask InitializeAsync() {
      Debug.Log("BattleMinerManager Initialization Started");
      await base.InitializeAsync();
      Debug.Log("BattleMinerManager Initialization Completed");
    }

    public override async UniTask ShutdownAsync() {
      Debug.Log("BattleMinerManager Shutdown Started");
      await base.ShutdownAsync();
      Debug.Log("BattleMinerManager Shutdown Completed");
    }

    public async UniTask StartFirstSceneAsync() {
      await servicesManager.GetService<ScenesService>().LoadSceneAsync(firstScene);
    }
  }
}
