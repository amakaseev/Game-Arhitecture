using Cysharp.Threading.Tasks;
using GameArchitecture;
using UnityEngine;

namespace BattleMiner
{
  [CreateAssetMenu(fileName = "BattleMinerGame", menuName = "BattleMinerGame")]
  public class BattleMinerGame: Game {
    [SerializeField] SceneConfig firstScene;
    [SerializeField] GameObject helloPrefab;

    public override async UniTask InitializeAsync() {
      Debug.Log("BattleMinerGame Initialization Started");
      var hello = Instantiate(helloPrefab);
      hello.SetActive(false);

      await base.InitializeAsync();

      await UniTask.Delay(2);
      hello.SetActive(true);
      await UniTask.Delay(2);
      Debug.Log("BattleMinerGame Initialization Completed");
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
