using UnityEngine;
using GameArchitecture;

namespace BattleMiner {

  public class GameStartup: MonoBehaviour {
    [SerializeField] Game game;

    async void Start() {
      Debug.Log("GameStartup...");
      await game.InitializeAsync();
      await game.Start();
    }

  }

}
