using UnityEngine;

namespace GameArchitecture {

  [CreateAssetMenu(fileName = "AudioConfig", menuName = "GameArchitecture/Configs/AudioConfig")]
  public class AudioConfig: ScriptableObject {
    [SerializeField] AudioClip clip;
    [Range(0.1f, 1)] public float randomVolume = 0.2f;
    [Range(0.1f, 1)] public float sameTime = 0.2f;
    [Range(0.1f, 1)] public float volume = 1;

    public void Play(AudioSource audioSource) {
      audioSource.PlayOneShot(clip, volume * Random.Range(1f - randomVolume, 1f));
    }
  }

}
