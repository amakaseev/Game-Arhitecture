using Cysharp.Threading.Tasks;
using GameArchitecture;
using UnityEngine;

namespace BattleMiner
{
  [CreateAssetMenu(fileName = "BattleMinerManager", menuName = "BattleMinerManager")]
  public class BattleMinerManager: GameManager {
    [SerializeField] SceneConfig firstScene;
    [SerializeField] ScenesService scenesService;
    [SerializeField] GameObject helloPrefab;

    public override async UniTask InitializeAsync() {
      Debug.Log("BattleMinerManager Initialization Started");
      var hello = Instantiate(helloPrefab);
      hello.SetActive(false);

      await base.InitializeAsync();

      await UniTask.Delay(2);
      hello.SetActive(true);
      await UniTask.Delay(2);
      Debug.Log("BattleMinerManager Initialization Completed");
    }

    public override async UniTask ShutdownAsync() {
      Debug.Log("BattleMinerManager Shutdown Started");
      await base.ShutdownAsync();
      Debug.Log("BattleMinerManager Shutdown Completed");
    }

    public async UniTask StartFirstSceneAsync() {
      await scenesService.LoadSceneAsync(firstScene);
    }
  }
}
