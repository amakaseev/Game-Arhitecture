using UnityEngine;

namespace BattleMiner {

  public class GameStartup: MonoBehaviour {
    [SerializeField] BattleMinerManager gameManager;

    async void Start() {
      Debug.Log("GameStartup...");
      await gameManager.InitializeAsync();
      Debug.Log("StartFirstScene...");
      //await gameManager.StartFirstSceneAsync();
    }

  }

}
