using Cysharp.Threading.Tasks;
using GameArchitecture;
using UnityEngine;

namespace BattleMiner
{
  [CreateAssetMenu(fileName = "BattleMinerGame", menuName = "BattleMinerGame")]
  public class BattleMinerGame: Game {
    [SerializeField] SceneConfig firstScene;

    public override async UniTask InitializeAsync() {
      Debug.Log("BattleMinerGame Initialization Started");
      await base.InitializeAsync();
      Debug.Log("BattleMinerGame Initialization Completed");
    }

    public override async UniTask ShutdownAsync() {
      Debug.Log("BattleMinerGame Shutdown Started");
      await base.ShutdownAsync();
      Debug.Log("BattleMinerGame Shutdown Completed");
    }

    public override async UniTask Start() {
      Debug.Log("asdasdasd");
      await UniTask.Delay(2000);
      await GetService<SceneService>().LoadSceneAsync(firstScene);
      await UniTask.Delay(2000);
      Debug.Log("ASDASDASD");
    }
  }
}
