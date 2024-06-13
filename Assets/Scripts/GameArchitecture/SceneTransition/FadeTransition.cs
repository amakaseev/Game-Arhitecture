using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  [RequireComponent(typeof(CanvasGroup))]
  public class FadeTransition: SceneTransition {
    protected override void Start() {
      base.Start();
    }

    public override UniTask Enter() {
      return FadeIn();
    }

    public override UniTask Exit() {
      return FadeOut();
    }

    private async UniTask FadeIn() {
      float startAlpha = 0f;
      float endAlpha = 1f;
      float elapsedTime = 0f;

      CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
      while (elapsedTime < duration) {
        elapsedTime += Time.deltaTime;
        canvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / duration);
        await UniTask.Yield();
      }

      canvasGroup.alpha = endAlpha;
    }

    private async UniTask FadeOut() {
      float startAlpha = 1f;
      float endAlpha = 0f;
      float elapsedTime = 0f;

      CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
      while (elapsedTime < duration) {
        elapsedTime += Time.deltaTime;
        canvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / duration);
        await UniTask.Yield();
      }

      canvasGroup.alpha = endAlpha;
    }
  }

}
