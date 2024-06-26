using UnityEngine;
using UnityEngine.UI;
using GameArchitecture;

namespace BattleMiner {

  public class GameStartup: MonoBehaviour {
    [SerializeField] Game game;
    [SerializeField] Text text;

    async void Start() {
      Debug.Log("<color=#00FF00>GameStartup...</color>");
      await game.InitializeAsync();
      await game.Start();
    }

    void Update() {
      text.text = Time.time.ToString("F2");
    }
  }

}
