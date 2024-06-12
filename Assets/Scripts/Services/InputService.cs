using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameArchitecture {

  public abstract class InputService<T>: Service where T: IInputActionCollection, new() {
    protected T inputActions;

    public override async UniTask InitializeAsync() {
        Debug.Log("Input Service Initialized");
        inputActions = new T();
        inputActions.Enable();
        await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

    public override async UniTask ShutdownAsync() {
        Debug.Log("Input Service Shutdown");
        inputActions.Disable();
        await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }
  }
  
}
