using UnityEngine;

namespace GameArchitecture {

  [CreateAssetMenu(fileName = "SceneConfig", menuName = "GameArchitecture/Configs/SceneConfig")]
  public class SceneConfig: ScriptableObject {
    [SerializeField] SceneTransition transition;

    public SceneTransition Transition => transition;
  }

}
