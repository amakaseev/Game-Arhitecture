using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace BattleMiner {

  [CreateAssetMenu(fileName = "GameInputService", menuName = "GameArchitecture/Services/GameInputService")]
  public class GameInputService: GameArchitecture.InputService<GameInput>, GameInput.IBattleActions, GameInput.ITouchActions {
    public GameInput.TouchActions TouchActions => inputActions.Touch;
    public GameInput.BattleActions BattleActions => inputActions.Battle;

    // Touch Actions
    public Action<bool, Vector2> PrimaryTouchContact;
    public Action<bool, Vector2> SecondaryTouchContact;
    public Action<Vector2> Wheel;
    public Action DoubleTap;
    public Vector2 PrimaryFingerPosition => inputActions.Touch.PrimaryFingerPosition.ReadValue<Vector2>();
    public Vector2 SecondaryFingerPosition => inputActions.Touch.SecondaryFingerPosition.ReadValue<Vector2>();

    // Battle Actions
    public Action<bool, Vector2> DragAndDrop;
    public Action<Vector2> DragPosition;

    public override async UniTask InitializeAsync() {
      await base.InitializeAsync();

      inputActions.Touch.Disable();
      inputActions.Battle.Disable();
      inputActions.Touch.SetCallbacks(this);
      inputActions.Battle.SetCallbacks(this);
    }

    public void Enable() => inputActions.Enable();
    public void Disable() => inputActions.Disable();

    // Touch actions
    public void OnPrimaryFingerPosition(InputAction.CallbackContext context) { }
    public void OnSecondaryFingerPosition(InputAction.CallbackContext context) { }

    public void OnPrimaryTouchContact(InputAction.CallbackContext context) {
      if (context.phase == InputActionPhase.Started) {
        PrimaryTouchContact?.Invoke(true, PrimaryFingerPosition);
      } else if (context.phase == InputActionPhase.Canceled) {
        PrimaryTouchContact?.Invoke(false, PrimaryFingerPosition);
      }
    }

    public void OnSecondaryTouchContact(InputAction.CallbackContext context) {
      if (context.phase == InputActionPhase.Started) {
        SecondaryTouchContact?.Invoke(true, SecondaryFingerPosition);
      } else if (context.phase == InputActionPhase.Canceled) {
        SecondaryTouchContact?.Invoke(false, SecondaryFingerPosition);
      }
    }

    public void OnWheel(InputAction.CallbackContext context) => Wheel?.Invoke(context.ReadValue<Vector2>());

    public void OnDoubleTap(InputAction.CallbackContext context) {
      if (context.phase == InputActionPhase.Performed) {
        DoubleTap?.Invoke();
      }
    }

    // Battle Actions
    public void OnDragAndDrop(InputAction.CallbackContext context) {
      if (context.phase == InputActionPhase.Started) {
        DragAndDrop?.Invoke(true, inputActions.Battle.DragPosition.ReadValue<Vector2>());
      } else if (context.phase == InputActionPhase.Canceled) {
        DragAndDrop?.Invoke(false, inputActions.Battle.DragPosition.ReadValue<Vector2>());
      }
    }

    public void OnDragPosition(InputAction.CallbackContext context) => DragPosition?.Invoke(context.ReadValue<Vector2>());
  }

}
