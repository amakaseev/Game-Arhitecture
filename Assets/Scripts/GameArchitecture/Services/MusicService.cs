using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  [CreateAssetMenu(fileName = "MusicService", menuName = "GameServices/MusicService")]
  public class MusicService: Service {
    public override async UniTask InitializeAsync() {
        Debug.Log("Music Service Initialized");
        // Инициализация системы для работы с музыкой
        await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

    public override async UniTask ShutdownAsync() {
        Debug.Log("Music Service Shutdown");
        // Очищение или завершение системы для работы с музыкой
        await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

    public void PlayMusic(AudioClip clip) {
        Debug.Log("Playing music: " + clip.name);
        // Код для воспроизведения музыки
    }

    public void StopMusic(AudioClip clip) {
        Debug.Log("Stopping music: " + clip.name);
        // Код для остановки музыки
    }
  }

}
