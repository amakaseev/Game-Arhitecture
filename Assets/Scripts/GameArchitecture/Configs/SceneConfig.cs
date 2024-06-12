using UnityEngine;

namespace GameArchitecture {

  [CreateAssetMenu(fileName = "SceneConfig", menuName = "GameArchitecture/Configs/SceneConfig")]
  public class SceneConfig: ScriptableObject {
    [System.Serializable]
    public class SceneTransitionConfig {
      [SerializeField, Range(0, 1)] float duration = 1;
      [SerializeField] Color color = Color.black;
    }

    [SerializeField] SceneTransitionConfig transitionIn;
    [SerializeField] SceneTransitionConfig transitionOut;
  }

}
