using Cysharp.Threading.Tasks;
using GameArchitecture;
using UnityEngine;

namespace BattleMiner
{
  [CreateAssetMenu(fileName = "BattleMinerGame", menuName = "BattleMinerGame")]
  public class BattleMinerGame: Game {
    [SerializeField] SceneConfig firstScene;

    public override async UniTask InitializeAsync() {
      Debug.Log("<color=#00FF00>BattleMinerGame</color> Initialization Started");
      await base.InitializeAsync();
      Debug.Log("<color=#00FF00>BattleMinerGame</color> Initialization Completed");
    }

    public override async UniTask ShutdownAsync() {
      Debug.Log("BattleMinerGame Shutdown Started");
      await base.ShutdownAsync();
      Debug.Log("BattleMinerGame Shutdown Completed");
    }

    public override async UniTask Start() {
      await GetService<SceneService>().LoadSceneAsync(firstScene);
    }
  }
}
