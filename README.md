<h1>DOTween-like simple tween library</h1>

<h2>Generics</h2>
<ul><code>FLTween.To(getter, setter, float to, float duration)</code></ul>
<ul><code>FLTween.To(getter, setter, Vector2 to, float duration)</code></ul>
<ul><code>FLTween.To(getter, setter, Vector3 to, float duration)</code></ul>
<ul><code>FLTween.To(getter, setter, Color to, float duration)</code></ul>

<h2>Utilities</h2>
<ul><code>FLTween.TweensById(string tweenId)</code></ul>
<ul><code>FLTween.Pause(string tweenId)</code></ul>
<ul><code>FLTween.Play(string tweenId)</code></ul>
<ul><code>FLTween.Kill(string tweenId)</code></ul>
<ul><code>FLTween.PauseAll()</code></ul>
<ul><code>FLTween.PlayAll()</code></ul>
<ul><code>FLTween.KillAll()</code></ul>
<ul><code>Source.FLPause()</code> Example : <code>transform.FLPause(), material.FLPause()</code></ul>
<ul><code>Source.FLPlay()</code></ul>
<ul><code>Source.FLKill()</code></ul>

<h2>Tween Methods</h2>
<ul><code>Kill()</code></ul>
<ul><code>Pause()</code></ul>
<ul><code>Play()</code></ul>

<h2>Tween Setup Chaining Methods</h2>
<ul><code>SetAs(TweenParams tweenParams)</code></ul>
<ul><code>SetId(string id)</code></ul>
<ul><code>SetDelay(float delay)</code></ul>
<ul><code>SetEase(EaseType easeType)</code></ul>
<ul><code>SetLoops(int loopCount, LoopType loopType)</code></ul>
<ul><code>OnStart(Action callBack)</code></ul>
<ul><code>OnPlay(Action callBack)</code></ul>
<ul><code>OnPause(Action callBack)</code></ul>
<ul><code>OnKill(Action callBack)</code></ul>
<ul><code>OnCompleteStep(Action callBack)</code></ul>
<ul><code>OnUpdate(Action callBack)</code></ul>
<ul><code>OnComplete(Action callBack)</code></ul>

<h2>Sequence</h2>
<ul><code>Append()</code></ul>
<ul><code>AppendInterval(float interval)</code></ul>
<ul><code>AppendCallback(Action callBack)</code></ul>
<ul><code>Prepend()</code></ul>
<ul><code>PrependInterval(float interval)</code></ul>
<ul><code>PrependCallback(Action callBack)</code></ul>
<ul><code>Join()</code></ul>
<ul><code>SetLoops(int loopCount, LoopType loopType)</code></ul>

<h2>Shortcuts</h2>
<h3>Transform Move Tweens</h3>
<h6>
FLMove, FLMoveX, FLMoveY, FLMoveZ, FLLocalMove, FLLocalMoveX, FLLocalMoveY, FLLocalMoveZ
</h6>
<h3>Transform Rotate Tweens</h3>
<h6>
FLRotate, FLRotateX, FLRotateY, FLRotateZ, FLLocalRotate, FLLocalRotateX, FLLocalRotateY, FLLocalRotateZ, FLRotateQuaternion, FLLocalRotateQuaternion, FLLookAt
</h6>
<h3>Transform Scale Tweens</h3>
<h6>
FLScale, FLScaleX, FLScaleY, FLScaleZ
</h6>
<h3>Rigidbody Tweens</h3>
<h6>
FLMove, FLMoveX, FLMoveY, FLMoveZ, FLRotate, FLRotateX, FLRotateY, FLRotateZ, FLLookat
</h6>
<h3>Rigidbody2D Tweens</h3>
<h6>
FLMove, FLMoveX, FLMoveY, FLRotate
</h6>
<h3>Material Tweens</h3>
<h6>
FLFade, FLColor, FLOffset, FLTiling
</h6>
<h3>Audio Source Tweens</h3>
<h6>
FLFade, FLPitch
</h6>
<h3>Camera Tweens</h3>
<h6>
FLColor, FLFieldOfView, FLOrthoSize
</h6>
<h3>Light Tweens</h3>
<h6>
FLColor, FLIntensity
</h6>
<h3>Sprite Renderer Tweens</h3>
<h6>
FLFade, FLColor
</h6>
<h3>UI - Image Tweens</h3>
<h6>
FLFade, FLColor, FLFillAmount
</h6>
<h3>UI - Outline Tweens</h3>
<h6>
FLFade, FLColor, FLDistance
</h6>
<h3>UI - RectTransform Tweens</h3>
<h6>
FLAnchorMax, FLAnchorMin, FLAnchorPos, FLAnchorPosX, FLAnchorPosY, FLPivot
</h6>
<h3>UI - Slider Tweens</h3>
<h6>
FLValue
</h6>
<h3>UI - TextMeshPro && TextMeshProUGUI Tweens</h3>
<h6>
FLColor, FLFaceColor, FLOutlineColor, FLFade, FLFaceFade, FLFontSize, FLScale 
</h6>
<h3>Time Tweens</h3>
<h6>
FLTimeScale
</h6>


















