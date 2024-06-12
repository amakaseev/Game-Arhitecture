using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  [CreateAssetMenu(fileName = "AudioService", menuName = "GameServices/AudioService")]
  public class AudioService: Service {
    public override async UniTask InitializeAsync() {
        Debug.Log("Audio Service Initialized");
        // Инициализация аудио системы
        await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

    public override async UniTask ShutdownAsync() {
        Debug.Log("Audio Service Shutdown");
        // Очищение или завершение аудио системы
        await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

    public void PlaySound(AudioClip clip) {
        Debug.Log("Playing sound: " + clip.name);
        // Код для воспроизведения звука
    }

    public void StopSound(AudioClip clip) {
        Debug.Log("Stopping sound: " + clip.name);
        // Код для остановки звука
    }
  }

}
