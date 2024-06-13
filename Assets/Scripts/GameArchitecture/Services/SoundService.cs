using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  [CreateAssetMenu(fileName = "SoundService", menuName = "GameArchitecture/Services/SoundService")]
  public class SoundService: Service {
    public override async UniTask InitializeAsync() {
        Debug.Log("<color=#FFFF00>Sound</color> Service Initialized");
        // Инициализация системы для работы с звуковыми эффектами
        await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

    public override async UniTask ShutdownAsync() {
        Debug.Log("Sound Service Shutdown");
        // Очищение или завершение системы для работы с звуковыми эффектами
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
