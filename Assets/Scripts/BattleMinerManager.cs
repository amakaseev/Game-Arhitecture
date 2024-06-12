using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleMiner
{
  [CreateAssetMenu(fileName = "BattleMinerManager", menuName = "BattleMinerManager")]
  public class BattleMinerManager: GameArchitecture.GameManager {
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
  }
}
