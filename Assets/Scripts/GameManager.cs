using UnityEngine;

namespace GameArhitecture {

  public class GameManager: ScriptableObject {
    public Service[] gameServices;

    private async void InitializeAsync() {
        // Асинхронная инициализация всех сервисов
        foreach (var service in gameServices) {
          await service.InitializeAsync();
        }
    }

    private async void OnApplicationQuit() {
        // Асинхронное завершение работы всех сервисов
        foreach (var service in gameServices) {
            await service.ShutdownAsync();
        }
    }
  }

}
