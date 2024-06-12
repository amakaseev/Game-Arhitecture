using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  public abstract class Service: ScriptableObject {
      public abstract UniTask InitializeAsync();
      public abstract UniTask ShutdownAsync();
  }

}