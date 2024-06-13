using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  public abstract class SceneTransition: MonoBehaviour {
    [SerializeField] protected float duration = 0.5f;

    protected virtual void Start () {
      DontDestroyOnLoad(gameObject);
    }

    public abstract UniTask Enter();
    public abstract UniTask Exit();
  }

}
