using UnityEngine;

namespace BattleMiner {

  public class GameStartup: MonoBehaviour {
    [SerializeField] BattleMinerManager gameManager;

    async void Start() {
      await gameManager.InitializeAsync();
      Debug.Log("GameStartup...");
      await gameManager.StartFirstSceneAsync();
    }

  }

}
