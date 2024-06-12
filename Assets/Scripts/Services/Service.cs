using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  public abstract class Service: ScriptableObject {
      public string serviceName;

      public abstract UniTask InitializeAsync();

      public virtual UniTask ShutdownAsync() {
          // Виртуальный метод, который может быть переопределен при необходимости
          return UniTask.CompletedTask;
      }
  }
  
}