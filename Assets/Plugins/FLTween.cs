using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace FLTweening {

    public static class FLTween {
        public static MonoBehaviour mono;
        public static List<Tween> tweens = new List<Tween>();
        public static List<Sequence> sequences = new List<Sequence>();
        public static void Init() {
            if (mono == null)
                mono = new GameObject("FLManager").AddComponent<FLManager>();
        }

        #region Tween Shortcuts
        //Transform
        public static Tween FLMove(this Transform transform, Vector3 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.Move);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericVector3Tween(transform, target, () => transform.position, x => transform.position = x, duration).SetTweenType(TweenType.Move);
            return tween;
        }
        public static Tween FLMoveX(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.MoveX);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(to, transform.position.y, transform.position.z);
            Func<Vector3> targetUpdater = () => new Vector3(to, transform.position.y, transform.position.z);
            tween = new GenericVector3Tween(transform, target, () => transform.position, x => transform.position = x, duration, targetUpdater).SetTweenType(TweenType.MoveX);
            return tween;
        }
        public static Tween FLMoveY(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.MoveY);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(transform.position.x, to, transform.position.z);
            Func<Vector3> targetUpdater = () => new Vector3(transform.position.x, to, transform.position.z);
            tween = new GenericVector3Tween(transform, target, () => transform.position, x => transform.position = x, duration, targetUpdater).SetTweenType(TweenType.MoveY);
            return tween;
        }
        public static Tween FLMoveZ(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.MoveZ);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(transform.position.x, transform.position.y, to);
            Func<Vector3> targetUpdater = () => new Vector3(transform.position.x, transform.position.y, to);
            tween = new GenericVector3Tween(transform, target, () => transform.position, x => transform.position = x, duration, targetUpdater).SetTweenType(TweenType.MoveZ);
            return tween;
        }
        public static Tween FLLocalMove(this Transform transform, Vector3 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.LocalMove);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericVector3Tween(transform, target, () => transform.localPosition, x => transform.localPosition = x, duration).SetTweenType(TweenType.LocalMove);
            return tween;
        }
        public static Tween FLLocalMoveX(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.LocalMoveX);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(to, transform.localPosition.y, transform.localPosition.z);
            Func<Vector3> targetUpdater = () => new Vector3(to, transform.localPosition.y, transform.localPosition.z);
            tween = new GenericVector3Tween(transform, target, () => transform.localPosition, x => transform.localPosition = x, duration, targetUpdater).SetTweenType(TweenType.LocalMoveX);
            return tween;
        }
        public static Tween FLLocalMoveY(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.LocalMoveY);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(transform.localPosition.x, to, transform.localPosition.z);
            Func<Vector3> targetUpdater = () => new Vector3(transform.localPosition.x, to, transform.localPosition.z);
            tween = new GenericVector3Tween(transform, target, () => transform.localPosition, x => transform.localPosition = x, duration, targetUpdater).SetTweenType(TweenType.LocalMoveY);
            return tween;
        }
        public static Tween FLLocalMoveZ(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.LocalMoveZ);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(transform.localPosition.x, transform.localPosition.y, to);
            Func<Vector3> targetUpdater = () => new Vector3(transform.localPosition.x, transform.localPosition.y, to);
            tween = new GenericVector3Tween(transform, target, () => transform.localPosition, x => transform.localPosition = x, duration, targetUpdater).SetTweenType(TweenType.LocalMoveZ);
            return tween;
        }
        public static Tween FLRotate(this Transform transform, Vector3 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.Rotate);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericRotateTween(transform, target, () => transform.eulerAngles, x => transform.eulerAngles = x, duration).SetTweenType(TweenType.Rotate);
            return tween;
        }
        public static Tween FLRotateX(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.RotateX);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(to, transform.eulerAngles.y, transform.eulerAngles.z);
            Func<Vector3> targetUpdater = () => new Vector3(to, transform.eulerAngles.y, transform.eulerAngles.z);
            tween = new GenericRotateTween(transform, target, () => transform.eulerAngles, x => transform.eulerAngles = x, duration, targetUpdater).SetTweenType(TweenType.RotateX);
            return tween;
        }
        public static Tween FLRotateY(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.RotateY);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(transform.eulerAngles.x, to, transform.eulerAngles.z);
            Func<Vector3> targetUpdater = () => new Vector3(transform.eulerAngles.x, to, transform.eulerAngles.z);
            tween = new GenericRotateTween(transform, target, () => transform.eulerAngles, x => transform.eulerAngles = x, duration, targetUpdater).SetTweenType(TweenType.RotateY);
            return tween;
        }
        public static Tween FLRotateZ(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.RotateZ);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, to);
            Func<Vector3> targetUpdater = () => new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, to);
            tween = new GenericRotateTween(transform, target, () => transform.eulerAngles, x => transform.eulerAngles = x, duration, targetUpdater).SetTweenType(TweenType.RotateZ);
            return tween;
        }
        public static Tween FLLocalRotate(this Transform transform, Vector3 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.LocalRotate);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericRotateTween(transform, target, () => transform.localEulerAngles, x => transform.localEulerAngles = x, duration).SetTweenType(TweenType.LocalRotate);
            return tween;
        }
        public static Tween FLLocalRotateX(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.LocalRotateX);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(to, transform.localEulerAngles.y, transform.localEulerAngles.z);
            Func<Vector3> targetUpdater = () => new Vector3(to, transform.localEulerAngles.y, transform.localEulerAngles.z);
            tween = new GenericRotateTween(transform, target, () => transform.localEulerAngles, x => transform.localEulerAngles = x, duration, targetUpdater).SetTweenType(TweenType.LocalRotateX);
            return tween;
        }
        public static Tween FLLocalRotateY(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.LocalRotateY);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(transform.localEulerAngles.x, to, transform.localEulerAngles.z);
            Func<Vector3> targetUpdater = () => new Vector3(transform.localEulerAngles.x, to, transform.localEulerAngles.z);
            tween = new GenericRotateTween(transform, target, () => transform.localEulerAngles, x => transform.localEulerAngles = x, duration, targetUpdater).SetTweenType(TweenType.LocalRotateY);
            return tween;
        }
        public static Tween FLLocalRotateZ(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.LocalRotateZ);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, to);
            Func<Vector3> targetUpdater = () => new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, to);
            tween = new GenericRotateTween(transform, target, () => transform.localEulerAngles, x => transform.localEulerAngles = x, duration, targetUpdater).SetTweenType(TweenType.LocalRotateZ);
            return tween;
        }
        public static Tween FLRotateQuaternion(this Transform transform, Quaternion target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.RotateQuaternion);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericRotateTween(transform, target.eulerAngles, () => transform.eulerAngles, x => transform.eulerAngles = x, duration).SetTweenType(TweenType.RotateQuaternion);
            return tween;
        }
        public static Tween FLLocalRotateQuaternion(this Transform transform, Quaternion target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.LocalRotateQuaternion);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericRotateTween(transform, target.eulerAngles, () => transform.localEulerAngles, x => transform.localEulerAngles = x, duration).SetTweenType(TweenType.LocalRotateQuaternion);
            return tween;
        }
        public static Tween FLLookAt(this Transform transform, Vector3 target, float duration, Vector3? upwards = null) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.LookAt);
            if (tween != null) {
                tween.Kill();
            }
            if (upwards == null) {
                upwards = Vector3.up;
            }
            Vector3 relativePos = target - transform.position;
            Quaternion targetRot = Quaternion.LookRotation(relativePos, (Vector3)upwards);
            tween = new GenericRotateTween(transform, targetRot.eulerAngles, () => transform.eulerAngles, x => transform.eulerAngles = x, duration).SetTweenType(TweenType.LookAt);
            return tween;
        }
        public static Tween FLScale(this Transform transform, Vector3 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.Scale);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericVector3Tween(transform, target, () => transform.localScale, x => transform.localScale = x, duration).SetTweenType(TweenType.Scale);
            return tween;
        }
        public static Tween FLScaleX(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.ScaleX);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(to, transform.localScale.y, transform.localScale.z);
            Func<Vector3> targetUpdater = () => new Vector3(to, transform.localScale.y, transform.localScale.z);
            tween = new GenericVector3Tween(transform, target, () => transform.localScale, x => transform.localScale = x, duration, targetUpdater).SetTweenType(TweenType.ScaleX);
            return tween;
        }
        public static Tween FLScaleY(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.ScaleY);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(transform.localScale.x, to, transform.localScale.z);
            Func<Vector3> targetUpdater = () => new Vector3(transform.localScale.x, to, transform.localScale.z);
            tween = new GenericVector3Tween(transform, target, () => transform.localScale, x => transform.localScale = x, duration, targetUpdater).SetTweenType(TweenType.ScaleY);
            return tween;
        }
        public static Tween FLScaleZ(this Transform transform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)transform && tn.GetTweenType() == TweenType.ScaleZ);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(transform.localScale.x, transform.localScale.y, to);
            Func<Vector3> targetUpdater = () => new Vector3(transform.localScale.x, transform.localScale.y, to);
            tween = new GenericVector3Tween(transform, target, () => transform.localScale, x => transform.localScale = x, duration, targetUpdater).SetTweenType(TweenType.ScaleZ);
            return tween;
        }
        //Rigidbody
        public static Tween FLMove(this Rigidbody rigidbody, Vector3 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody && tn.GetTweenType() == TweenType.RBMove);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericVector3Tween(rigidbody, target, () => rigidbody.position, x => rigidbody.position = x, duration).SetTweenType(TweenType.RBMove);
            return tween;
        }
        public static Tween FLMoveX(this Rigidbody rigidbody, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody && tn.GetTweenType() == TweenType.RBMoveX);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(to, rigidbody.position.y, rigidbody.position.z);
            Func<Vector3> targetUpdater = () => new Vector3(to, rigidbody.position.y, rigidbody.position.z);
            tween = new GenericVector3Tween(rigidbody, target, () => rigidbody.position, x => rigidbody.position = x, duration, targetUpdater).SetTweenType(TweenType.RBMoveX);
            return tween;
        }
        public static Tween FLMoveY(this Rigidbody rigidbody, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody && tn.GetTweenType() == TweenType.RBMoveY);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(rigidbody.position.x, to, rigidbody.position.z);
            Func<Vector3> targetUpdater = () => new Vector3(rigidbody.position.x, to, rigidbody.position.z);
            tween = new GenericVector3Tween(rigidbody, target, () => rigidbody.position, x => rigidbody.position = x, duration, targetUpdater).SetTweenType(TweenType.RBMoveY);
            return tween;
        }
        public static Tween FLMoveZ(this Rigidbody rigidbody, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody && tn.GetTweenType() == TweenType.RBMoveZ);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(rigidbody.position.x, rigidbody.position.y, to);
            Func<Vector3> targetUpdater = () => new Vector3(rigidbody.position.x, rigidbody.position.y, to);
            tween = new GenericVector3Tween(rigidbody, target, () => rigidbody.position, x => rigidbody.position = x, duration, targetUpdater).SetTweenType(TweenType.RBMoveZ);
            return tween;
        }
        public static Tween FLRotate(this Rigidbody rigidbody, Vector3 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody && tn.GetTweenType() == TweenType.RBRotate);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericRotateTween(rigidbody, target, () => rigidbody.transform.eulerAngles, x => rigidbody.transform.eulerAngles = x, duration).SetTweenType(TweenType.RBRotate);
            return tween;
        }
        public static Tween FLRotateX(this Rigidbody rigidbody, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody && tn.GetTweenType() == TweenType.RBRotateX);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(to, rigidbody.transform.eulerAngles.y, rigidbody.transform.eulerAngles.z);
            Func<Vector3> targetUpdater = () => new Vector3(to, rigidbody.transform.eulerAngles.y, rigidbody.transform.eulerAngles.z);
            tween = new GenericRotateTween(rigidbody, target, () => rigidbody.transform.eulerAngles, x => rigidbody.transform.eulerAngles = x, duration, targetUpdater).SetTweenType(TweenType.RBRotateX);
            return tween;
        }
        public static Tween FLRotateY(this Rigidbody rigidbody, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody && tn.GetTweenType() == TweenType.RBRotateY);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(rigidbody.transform.eulerAngles.x, to, rigidbody.transform.eulerAngles.z);
            Func<Vector3> targetUpdater = () => new Vector3(rigidbody.transform.eulerAngles.x, to, rigidbody.transform.eulerAngles.z);
            tween = new GenericRotateTween(rigidbody, target, () => rigidbody.transform.eulerAngles, x => rigidbody.transform.eulerAngles = x, duration, targetUpdater).SetTweenType(TweenType.RBRotateY);
            return tween;
        }
        public static Tween FLRotateZ(this Rigidbody rigidbody, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody && tn.GetTweenType() == TweenType.RBRotateZ);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(rigidbody.transform.eulerAngles.x, rigidbody.transform.eulerAngles.y, to);
            Func<Vector3> targetUpdater = () => new Vector3(rigidbody.transform.eulerAngles.x, rigidbody.transform.eulerAngles.y, to);
            tween = new GenericRotateTween(rigidbody, target, () => rigidbody.transform.eulerAngles, x => rigidbody.transform.eulerAngles = x, duration, targetUpdater).SetTweenType(TweenType.RBRotateZ);
            return tween;
        }
        public static Tween FLLookAt(this Rigidbody rigidbody, Vector3 target, float duration, Vector3? upwards = null) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody && tn.GetTweenType() == TweenType.RBLookAt);
            if (tween != null) {
                tween.Kill();
            }
            if (upwards == null) {
                upwards = Vector3.up;
            }
            Vector3 relativePos = target - rigidbody.position;
            Quaternion targetRot = Quaternion.LookRotation(relativePos, (Vector3)upwards);
            tween = new GenericRotateTween(rigidbody, targetRot.eulerAngles, () => rigidbody.transform.eulerAngles, x => rigidbody.transform.eulerAngles = x, duration).SetTweenType(TweenType.RBLookAt);
            return tween;
        }
        //Material
        public static Tween FLFade(this Material material, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)material && tn.GetTweenType() == TweenType.MaterialFade);
            if (tween != null) {
                tween.Kill();
            }
            Color color = material.color;
            color.a = Mathf.Clamp01(to);
            tween = new GenericColorTween(material, color, () => material.color, x => material.color = x, duration).SetTweenType(TweenType.MaterialFade);
            return tween;
        }
        public static Tween FLColor(this Material material, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)material && tn.GetTweenType() == TweenType.MaterialColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(material, target, () => material.color, x => material.color = x, duration).SetTweenType(TweenType.MaterialColor);
            return tween;
        }
        public static Tween FLOffset(this Material material, Vector2 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)material && tn.GetTweenType() == TweenType.MaterialOffset);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericVector2Tween(material, target, () => material.mainTextureOffset, x => material.mainTextureOffset = x, duration).SetTweenType(TweenType.MaterialOffset);
            return tween;
        }
        public static Tween FLTiling(this Material material, Vector2 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)material && tn.GetTweenType() == TweenType.MaterialTiling);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericVector2Tween(material, target, () => material.mainTextureScale, x => material.mainTextureScale = x, duration).SetTweenType(TweenType.MaterialTiling);
            return tween;
        }
        //AudioGetSource()
        public static Tween FLFade(this AudioSource audioSource, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericFloatTween>().ToList().Find(tn => tn.GetSource() == (object)audioSource && tn.GetTweenType() == TweenType.AudioSourceFade);
            if (tween != null) {
                tween.Kill();
            }

            tween = new GenericFloatTween(audioSource, Mathf.Clamp01(to), () => audioSource.volume, x => audioSource.volume = x, duration).SetTweenType(TweenType.AudioSourceFade);
            return tween;
        }
        public static Tween FLPitch(this AudioSource audioSource, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericFloatTween>().ToList().Find(tn => tn.GetSource() == (object)audioSource && tn.GetTweenType() == TweenType.AudioSourcePitch);
            if (tween != null) {
                tween.Kill();
            }

            tween = new GenericFloatTween(audioSource, to, () => audioSource.pitch, x => audioSource.pitch = x, duration).SetTweenType(TweenType.AudioSourcePitch);
            return tween;
        }
        //Camera
        public static Tween FLColor(this Camera camera, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)camera && tn.GetTweenType() == TweenType.CameraColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(camera, target, () => camera.backgroundColor, x => camera.backgroundColor = x, duration).SetTweenType(TweenType.CameraColor);
            return tween;
        }
        public static Tween FLFieldOfView(this Camera camera, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericFloatTween>().ToList().Find(tn => tn.GetSource() == (object)camera && tn.GetTweenType() == TweenType.CameraFOV);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericFloatTween(camera, to, () => camera.fieldOfView, x => camera.fieldOfView = x, duration).SetTweenType(TweenType.CameraFOV);
            return tween;
        }
        public static Tween FLOrthoSize(this Camera camera, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericFloatTween>().ToList().Find(tn => tn.GetSource() == (object)camera && tn.GetTweenType() == TweenType.CameraOrthoSize);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericFloatTween(camera, to, () => camera.orthographicSize, x => camera.orthographicSize = x, duration).SetTweenType(TweenType.CameraOrthoSize);
            return tween;
        }
        //Light
        public static Tween FLColor(this Light light, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)light && tn.GetTweenType() == TweenType.LightColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(light, target, () => light.color, x => light.color = x, duration).SetTweenType(TweenType.LightColor);
            return tween;
        }
        public static Tween FLIntensity(this Light light, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericFloatTween>().ToList().Find(tn => tn.GetSource() == (object)light && tn.GetTweenType() == TweenType.LightIntensity);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericFloatTween(light, to, () => light.intensity, x => light.intensity = x, duration).SetTweenType(TweenType.LightIntensity);
            return tween;
        }
        //2D - Sprire Renderer
        public static Tween FLFade(this SpriteRenderer spriteRenderer, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)spriteRenderer && tn.GetTweenType() == TweenType.SRColor);
            if (tween != null) {
                tween.Kill();
            }
            Color color = spriteRenderer.color;
            color.a = Mathf.Clamp01(to);
            tween = new GenericColorTween(spriteRenderer, color, () => spriteRenderer.color, x => spriteRenderer.color = x, duration).SetTweenType(TweenType.SRColor);
            return tween;
        }
        public static Tween FLColor(this SpriteRenderer spriteRenderer, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)spriteRenderer && tn.GetTweenType() == TweenType.SRFade);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(spriteRenderer, target, () => spriteRenderer.color, x => spriteRenderer.color = x, duration).SetTweenType(TweenType.SRFade);
            return tween;
        }
        //2D - Rigidbody2D
        public static Tween FLMove(this Rigidbody2D rigidbody2d, Vector2 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody2d && tn.GetTweenType() == TweenType.RB2DMove);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericVector2Tween(rigidbody2d, target, () => rigidbody2d.position, x => rigidbody2d.position = x, duration).SetTweenType(TweenType.RB2DMove);
            return tween;
        }
        public static Tween FLMoveX(this Rigidbody2D rigidbody2d, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody2d && tn.GetTweenType() == TweenType.RB2DMoveX);
            if (tween != null) {
                tween.Kill();
            }
            Vector2 target = new Vector2(to, rigidbody2d.position.y);
            Func<Vector2> targetUpdater = () => new Vector2(to, rigidbody2d.position.y);
            tween = new GenericVector2Tween(rigidbody2d, target, () => rigidbody2d.position, x => rigidbody2d.position = x, duration, targetUpdater).SetTweenType(TweenType.RB2DMoveX);
            return tween;
        }
        public static Tween FLMoveY(this Rigidbody2D rigidbody2d, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody2d && tn.GetTweenType() == TweenType.RB2DMoveY);
            if (tween != null) {
                tween.Kill();
            }
            Vector2 target = new Vector2(rigidbody2d.position.x, to);
            Func<Vector2> targetUpdater = () => new Vector2(rigidbody2d.position.x, to);
            tween = new GenericVector2Tween(rigidbody2d, target, () => rigidbody2d.position, x => rigidbody2d.position = x, duration, targetUpdater).SetTweenType(TweenType.RB2DMoveY);
            return tween;
        }
        public static Tween FLRotate(this Rigidbody2D rigidbody2d, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericRotateTween>().ToList().Find(tn => tn.GetSource() == (object)rigidbody2d && tn.GetTweenType() == TweenType.RB2DRotate);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(0, 0, to);
            tween = new GenericRotateTween(rigidbody2d, target, () => rigidbody2d.transform.eulerAngles, x => rigidbody2d.transform.eulerAngles = x, duration).SetTweenType(TweenType.RB2DRotate);
            return tween;
        }
        //UI - Image
        public static Tween FLColor(this Image image, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)image && tn.GetTweenType() == TweenType.UIImageColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(image, target, () => image.color, x => image.color = x, duration).SetTweenType(TweenType.UIImageColor);
            return tween;
        }
        public static Tween FLFade(this Image image, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)image && tn.GetTweenType() == TweenType.UIImageFade);
            if (tween != null) {
                tween.Kill();
            }
            Color color = image.color;
            color.a = Mathf.Clamp01(to);
            tween = new GenericColorTween(image, color, () => image.color, x => image.color = x, duration).SetTweenType(TweenType.UIImageFade);
            return tween;
        }
        public static Tween FLFillAmount(this Image image, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericFloatTween>().ToList().Find(tn => tn.GetSource() == (object)image && tn.GetTweenType() == TweenType.UIImageFillAmount);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericFloatTween(image, Mathf.Clamp01(to), () => image.fillAmount, x => image.fillAmount = x, duration).SetTweenType(TweenType.UIImageFillAmount);
            return tween;
        }
        //UI - Outline
        public static Tween FLColor(this Outline outline, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)outline && tn.GetTweenType() == TweenType.UIOutlineColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(outline, target, () => outline.effectColor, x => outline.effectColor = x, duration).SetTweenType(TweenType.UIOutlineColor);
            return tween;
        }
        public static Tween FLFade(this Outline outline, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)outline && tn.GetTweenType() == TweenType.UIOutlineFade);
            if (tween != null) {
                tween.Kill();
            }
            Color color = outline.effectColor;
            color.a = Mathf.Clamp01(to);
            tween = new GenericColorTween(outline, color, () => outline.effectColor, x => outline.effectColor = x, duration).SetTweenType(TweenType.UIOutlineFade);
            return tween;
        }
        public static Tween FLDistance(this Outline outline, Vector2 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)outline && tn.GetTweenType() == TweenType.UIOutlineDistance);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericVector2Tween(outline, target, () => outline.effectDistance, x => outline.effectDistance = x, duration).SetTweenType(TweenType.UIOutlineDistance);
            return tween;
        }
        //UI - RectTransform
        public static Tween FLAnchorMax(this RectTransform rectTransform, Vector2 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)rectTransform && tn.GetTweenType() == TweenType.UIAnchorMax);
            if (tween != null) {
                tween.Kill();
            }
            target.x = Mathf.Clamp01(target.x);
            target.y = Mathf.Clamp01(target.y);
            tween = new GenericVector2Tween(rectTransform, target, () => rectTransform.anchorMax, x => rectTransform.anchorMax = x, duration).SetTweenType(TweenType.UIAnchorMax);
            return tween;
        }
        public static Tween FLAnchorMin(this RectTransform rectTransform, Vector2 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)rectTransform && tn.GetTweenType() == TweenType.UIAnchorMin);
            if (tween != null) {
                tween.Kill();
            }
            target.x = Mathf.Clamp01(target.x);
            target.y = Mathf.Clamp01(target.y);
            tween = new GenericVector2Tween(rectTransform, target, () => rectTransform.anchorMin, x => rectTransform.anchorMin = x, duration).SetTweenType(TweenType.UIAnchorMin);
            return tween;
        }
        public static Tween FLAnchorPos(this RectTransform rectTransform, Vector2 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)rectTransform && tn.GetTweenType() == TweenType.UIAnchorPos);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericVector2Tween(rectTransform, target, () => rectTransform.anchoredPosition, x => rectTransform.anchoredPosition = x, duration).SetTweenType(TweenType.UIAnchorPos);
            return tween;
        }
        public static Tween FLAnchorPosX(this RectTransform rectTransform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)rectTransform && tn.GetTweenType() == TweenType.UIAnchorPosX);
            if (tween != null) {
                tween.Kill();
            }
            Vector2 target = new Vector2(to, rectTransform.anchoredPosition.y);
            Func<Vector2> targetUpdater = () => new Vector2(to, rectTransform.anchoredPosition.y);
            tween = new GenericVector2Tween(rectTransform, target, () => rectTransform.anchoredPosition, x => rectTransform.anchoredPosition = x, duration, targetUpdater).SetTweenType(TweenType.UIAnchorPosX);
            return tween;
        }
        public static Tween FLAnchorPosY(this RectTransform rectTransform, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)rectTransform && tn.GetTweenType() == TweenType.UIAnchorPosY);
            if (tween != null) {
                tween.Kill();
            }
            Vector2 target = new Vector2(rectTransform.anchoredPosition.x, to);
            Func<Vector2> targetUpdater = () => new Vector2(rectTransform.anchoredPosition.x, to);
            tween = new GenericVector2Tween(rectTransform, target, () => rectTransform.anchoredPosition, x => rectTransform.anchoredPosition = x, duration, targetUpdater).SetTweenType(TweenType.UIAnchorPosY);
            return tween;
        }
        public static Tween FLPivot(this RectTransform rectTransform, Vector2 target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector2Tween>().ToList().Find(tn => tn.GetSource() == (object)rectTransform && tn.GetTweenType() == TweenType.UIPivot);
            if (tween != null) {
                tween.Kill();
            }
            target.x = Mathf.Clamp01(target.x);
            target.y = Mathf.Clamp01(target.y);
            tween = new GenericVector2Tween(rectTransform, target, () => rectTransform.pivot, x => rectTransform.pivot = x, duration).SetTweenType(TweenType.UIPivot);
            return tween;
        }
        //UI - Slider
        public static Tween FLValue(this Slider slider, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericFloatTween>().ToList().Find(tn => tn.GetSource() == (object)slider && tn.GetTweenType() == TweenType.UISliderValue);
            if (tween != null) {
                tween.Kill();
            }
            to = Mathf.Clamp(to, slider.minValue, slider.maxValue);
            tween = new GenericFloatTween(slider, to, () => slider.value, x => slider.value = x, duration).SetTweenType(TweenType.UISliderValue);
            return tween;
        }
        //UI - Text
        public static Tween FLColor(this Text text, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)text && tn.GetTweenType() == TweenType.UITextColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(text, target, () => text.color, x => text.color = x, duration).SetTweenType(TweenType.UITextColor);
            return tween;
        }
        public static Tween FLFade(this Text text, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)text && tn.GetTweenType() == TweenType.UITextFade);
            if (tween != null) {
                tween.Kill();
            }
            Color color = text.color;
            color.a = Mathf.Clamp01(to);
            tween = new GenericColorTween(text, color, () => text.color, x => text.color = x, duration).SetTweenType(TweenType.UITextFade);
            return tween;
        }
        //UI - TextMeshPro && TextMeshProUGUI
        public static Tween FLScale(this TextMeshPro tmp, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPScale);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(to, to, to);
            tween = new GenericVector3Tween(tmp, target, () => tmp.transform.localScale, x => tmp.transform.localScale = x, duration).SetTweenType(TweenType.TMPScale);
            return tween;
        }
        public static Tween FLColor(this TextMeshPro tmp, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(tmp, target, () => tmp.color, x => tmp.color = x, duration).SetTweenType(TweenType.TMPColor);
            return tween;
        }
        public static Tween FLFaceColor(this TextMeshPro tmp, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPFaceColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(tmp, target, () => tmp.faceColor, x => tmp.faceColor = x, duration).SetTweenType(TweenType.TMPFaceColor);
            return tween;
        }
        public static Tween FLOutlineColor(this TextMeshPro tmp, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPOutlineColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(tmp, target, () => tmp.outlineColor, x => tmp.outlineColor = x, duration).SetTweenType(TweenType.TMPOutlineColor);
            return tween;
        }
        public static Tween FLFade(this TextMeshPro tmp, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPFade);
            if (tween != null) {
                tween.Kill();
            }
            Color color = tmp.color;
            color.a = Mathf.Clamp01(to);
            tween = new GenericColorTween(tmp, color, () => tmp.color, x => tmp.color = x, duration).SetTweenType(TweenType.TMPFade);
            return tween;
        }
        public static Tween FLFaceFade(this TextMeshPro tmp, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPFaceFade);
            if (tween != null) {
                tween.Kill();
            }
            Color color = tmp.faceColor;
            color.a = Mathf.Clamp01(to);
            tween = new GenericColorTween(tmp, color, () => tmp.faceColor, x => tmp.faceColor = x, duration).SetTweenType(TweenType.TMPFaceFade);
            return tween;
        }
        public static Tween FLFontSize(this TextMeshPro tmp, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericFloatTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPFontSize);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericFloatTween(tmp, to, () => tmp.fontSize, x => tmp.fontSize = x, duration).SetTweenType(TweenType.TMPFontSize);
            return tween;
        }
        //UI - TextMeshProUGUI
        public static Tween FLScale(this TextMeshProUGUI tmp, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericVector3Tween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPUIScale);
            if (tween != null) {
                tween.Kill();
            }
            Vector3 target = new Vector3(to, to, to);
            tween = new GenericVector3Tween(tmp, target, () => tmp.transform.localScale, x => tmp.transform.localScale = x, duration).SetTweenType(TweenType.TMPUIScale);
            return tween;
        }
        public static Tween FLColor(this TextMeshProUGUI tmp, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPUIColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(tmp, target, () => tmp.color, x => tmp.color = x, duration).SetTweenType(TweenType.TMPUIColor);
            return tween;
        }
        public static Tween FLFaceColor(this TextMeshProUGUI tmp, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPUIFaceColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(tmp, target, () => tmp.faceColor, x => tmp.faceColor = x, duration).SetTweenType(TweenType.TMPUIFaceColor);
            return tween;
        }
        public static Tween FLOutlineColor(this TextMeshProUGUI tmp, Color target, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPUIOutlineColor);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericColorTween(tmp, target, () => tmp.outlineColor, x => tmp.outlineColor = x, duration).SetTweenType(TweenType.TMPUIOutlineColor);
            return tween;
        }
        public static Tween FLFade(this TextMeshProUGUI tmp, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPUIFade);
            if (tween != null) {
                tween.Kill();
            }
            Color color = tmp.color;
            color.a = Mathf.Clamp01(to);
            tween = new GenericColorTween(tmp, color, () => tmp.color, x => tmp.color = x, duration).SetTweenType(TweenType.TMPUIFade);
            return tween;
        }
        public static Tween FLFaceFade(this TextMeshProUGUI tmp, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericColorTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPUIFaceFade);
            if (tween != null) {
                tween.Kill();
            }
            Color color = tmp.faceColor;
            color.a = Mathf.Clamp01(to);
            tween = new GenericColorTween(tmp, color, () => tmp.faceColor, x => tmp.faceColor = x, duration).SetTweenType(TweenType.TMPUIFaceFade);
            return tween;
        }
        public static Tween FLFontSize(this TextMeshProUGUI tmp, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericFloatTween>().ToList().Find(tn => tn.GetSource() == (object)tmp && tn.GetTweenType() == TweenType.TMPUIFontSize);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericFloatTween(tmp, to, () => tmp.fontSize, x => tmp.fontSize = x, duration).SetTweenType(TweenType.TMPUIFontSize);
            return tween;
        }
        public static Tween FLTimeScale(this Tween twn, float to, float duration) {
            Tween tween;
            tween = tweens.OfType<GenericFloatTween>().ToList().Find(tn => tn.GetSource() == (object)twn && tn.GetTweenType() == TweenType.TweenTimeScale);
            if (tween != null) {
                tween.Kill();
            }
            tween = new GenericFloatTween(twn, to, () => twn.timeScale, x => twn.timeScale = x, duration).SetTweenType(TweenType.TweenTimeScale);
            return tween;
        }
        #endregion

        #region FLTween.To static methods
        public static Tween To(Func<float> getter, Func<float, float> setter, float to, float duration) {
            Tween tween = new GenericFloatTween(null, to, getter, setter, duration);
            return tween;
        }
        public static Tween To(Func<Vector2> getter, Func<Vector2, Vector2> setter, Vector2 to, float duration) {
            Tween tween = new GenericVector2Tween(null, to, getter, setter, duration);
            return tween;
        }
        public static Tween To(Func<Vector3> getter, Func<Vector3, Vector3> setter, Vector3 to, float duration) {
            Tween tween = new GenericVector3Tween(null, to, getter, setter, duration);
            return tween;
        }
        public static Tween To(Func<Color> getter, Func<Color, Color> setter, Color to, float duration) {
            Tween tween = new GenericColorTween(null, to, getter, setter, duration);
            return tween;
        }
        #endregion

        #region FLTween Utilities Static Methods
        public static List<Tween> TweensById(string id) {
            return tweens.Where(twn => twn.GetId() == id).ToList();
        }
        public static void FLPause(this object source) {
            tweens.FindAll(t => t.GetSource() == source).ForEach(tw => tw.Pause());
        }
        public static void FLPlay(this object source) {
            tweens.FindAll(t => t.GetSource() == source).ForEach(tw => tw.Play());
        }
        public static void FLKill(this object source) {
            tweens.FindAll(t => t.GetSource() == source).ForEach(tw => tw.Kill());
        }
        public static void PauseAll() {
            foreach (var tween in tweens) {
                tween.Pause();
            }
        }
        public static void PlayAll() {
            foreach (var tween in tweens) {
                tween.Play();
            }
        }
        public static void KillAll() {
            foreach (var tween in tweens.ToList()) {
                tween.Kill();
            }
        }
        public static void Pause(string tweenID) {
            tweens.FindAll(t => t.GetId() == tweenID).ForEach(twn => twn.Pause());
        }
        public static void Play(string tweenID) {
            tweens.FindAll(t => t.GetId() == tweenID).ForEach(twn => twn.Play());
        }
        public static void Kill(string tweenID) {
            tweens.FindAll(t => t.GetId() == tweenID).ForEach(twn => twn.Kill());
        }
        #endregion

        public static Sequence Sequence() {
            return new Sequence();
        }
    }
    public class Sequence {

        private List<List<Tween>> _seqTweens = new List<List<Tween>>();
        private int _seqIndex = 0;
        private int _updateIndex = 0;
        private int _loopIndex = 0;
        protected int LoopCount { get; set; } = 1;
        protected LoopType LoopType { get; set; } = LoopType.Restart;
        public Sequence() {
            FLTween.sequences.Add(this);
        }
        public Sequence Append(Tween tween) {
            FLTween.tweens.Remove(tween);
            _seqTweens.Add(new List<Tween>());
            _seqTweens[_seqIndex].Add(tween);
            _seqIndex++;
            return this;
        }
        public Sequence Prepend(Tween tween) {
            FLTween.tweens.Remove(tween);
            _seqTweens.Insert(0, new List<Tween>());
            _seqTweens[0].Add(tween);
            _seqIndex++;
            return this;
        }
        public Sequence Join(Tween tween) {
            FLTween.tweens.Remove(tween);
            _seqTweens[_seqIndex - 1].Add(tween);
            return this;
        }
        public Sequence AppendInterval(float interval) {
            var tween = new GenericDummyTween(0, 0, 0, 0, 0).SetDelay(interval);
            FLTween.tweens.Remove(tween);
            _seqTweens.Add(new List<Tween>());
            _seqTweens[_seqIndex].Add(tween);
            _seqIndex++;
            return this;
        }
        public Sequence PrependInterval(float interval) {
            var tween = new GenericDummyTween(0, 0, 0, 0, 0).SetDelay(interval);
            FLTween.tweens.Remove(tween);
            _seqTweens.Insert(0, new List<Tween>());
            _seqTweens[0].Add(tween);
            _seqIndex++;
            return this;
        }
        public Sequence AppendCallback(Action callBack) {
            var tween = new GenericDummyTween(0, 0, 0, 0, 0).OnStart(callBack);
            FLTween.tweens.Remove(tween);
            _seqTweens.Add(new List<Tween>());
            _seqTweens[_seqIndex].Add(tween);
            _seqIndex++;
            return this;
        }
        public Sequence PrependCallback(Action callBack) {
            var tween = new GenericDummyTween(0, 0, 0, 0, 0).OnStart(callBack);
            FLTween.tweens.Remove(tween);
            _seqTweens.Insert(0, new List<Tween>());
            _seqTweens[0].Add(tween);
            _seqIndex++;
            return this;
        }
        public Sequence SetLoops(int loopCount, LoopType loopType) {
            LoopCount = loopCount > 0 ? loopCount : int.MaxValue;  // -1 : infinite, > 0 : limited
            LoopType = loopType;
            return this;
        }

        public void UpdateSequence() {
            bool isAllActive;
            if (_loopIndex < LoopCount) {
                if (_updateIndex < _seqTweens.Count) {
                    foreach (var tween in _seqTweens[_updateIndex]) {
                        tween.UpdateTween();
                        isAllActive = false;
                        foreach (var twn in _seqTweens[_updateIndex]) {
                            if (twn.IsActive()) {
                                isAllActive = true;
                            }
                        }
                        if (!isAllActive) {
                            _updateIndex++;
                        }
                    }
                }
                else {
                    if (_loopIndex < LoopCount - 1) {
                        _updateIndex = 0;
                        _loopIndex++;
                        if (LoopType == LoopType.Restart) {
                            ResetSeqTween();
                        }
                        else if (LoopType == LoopType.Yoyo) {
                            _seqTweens.Reverse();
                            ReverseSeqTween();
                        }
                    }
                    else {
                        FLTween.sequences.Remove(this);
                    }
                }
            }
        }

        public void ResetSeqTween() {
            foreach (var tweens in _seqTweens) {
                foreach (var tween in tweens) {
                    tween.Reset();
                }
            }
        }
        public void ReverseSeqTween() {
            foreach (var tweens in _seqTweens) {
                foreach (var tween in tweens) {
                    tween.Reverse();
                }
            }
        }

    }
    public class FLManager : MonoBehaviour {
        private void Update() {
            if (FLTween.tweens.Count > 0) {
                foreach (var tween in FLTween.tweens.ToList()) {
                    tween.UpdateTween();
                }
            }
            if (FLTween.sequences.Count > 0) {
                foreach (var sequence in FLTween.sequences.ToList()) {
                    sequence.UpdateSequence();
                }
            }
        }
    }

    public enum EaseType {
        Linear,
        EaseInSine,
        EaseOutSine,
        EaseInOutSine,
        EaseInQuad,
        EaseOutQuad,
        EaseInOutQuad,
        EaseInCubic,
        EaseOutCubic,
        EaseInOutCubic,
        EaseInQuart,
        EaseOutQuart,
        EaseInOutQuart,
        EaseInQuint,
        EaseOutQuint,
        EaseInOutQuint,
        EaseInExpo,
        EaseOutExpo,
        EaseInOutExpo,
        EaseInCirc,
        EaseOutCirc,
        EaseInOutCirc,
        EaseInBack,
        EaseOutBack,
        EaseInOutBack,
        EaseInElastic,
        EaseOutElastic,
        EaseInOutElastic,
        EaseInBounce,
        EaseOutBounce,
        EaseInOutBounce
    }
    public enum LoopType {
        Restart,
        Yoyo,
        Incremental
    }
    public enum TweenType {
        None,
        Move, MoveX, MoveY, MoveZ,
        LocalMove, LocalMoveX, LocalMoveY, LocalMoveZ,
        Rotate, RotateX, RotateY, RotateZ,
        LocalRotate, LocalRotateX, LocalRotateY, LocalRotateZ,
        RotateQuaternion, LocalRotateQuaternion, LookAt,
        Scale, ScaleX, ScaleY, ScaleZ,
        RBMove, RBMoveX, RBMoveY, RBMoveZ,
        RB2DMove, RB2DMoveX, RB2DMoveY, RB2DRotate,
        RBRotate, RBRotateX, RBRotateY, RBRotateZ, RBLookAt,
        MaterialColor, MaterialFade, MaterialOffset, MaterialTiling,
        AudioSourceFade, AudioSourcePitch,
        CameraColor, CameraFOV, CameraOrthoSize,
        LightColor, LightIntensity,
        SRColor, SRFade,
        UIImageColor, UIImageFade, UIImageFillAmount,
        UIOutlineColor, UIOutlineFade, UIOutlineDistance,
        UIAnchorMax, UIAnchorMin, UIAnchorPos, UIAnchorPosX, UIAnchorPosY, UIPivot,
        UISliderValue,
        UITextColor, UITextFade,
        TMPScale, TMPColor, TMPFaceColor, TMPFade, TMPFaceFade, TMPFontSize, TMPOutlineColor,
        TMPUIScale, TMPUIColor, TMPUIFaceColor, TMPUIFade, TMPUIFaceFade, TMPUIFontSize, TMPUIOutlineColor,
        TweenTimeScale, ShakePos
    }
    public class Ease {

        public delegate float EaseFunc(float t);
        public EaseFunc EaseMethod;
        public EaseType EaseType { get; set; }
        public Ease() {
            EaseType = EaseType.Linear;
            SetEaseFunc(EaseType);
        }

        public void SetEaseFunc(EaseType easeType) {
            switch (easeType) {
                case EaseType.Linear:
                    EaseMethod = EaseLinear;
                    break;
                case EaseType.EaseInSine:
                    EaseMethod = EaseInSine;
                    break;
                case EaseType.EaseOutSine:
                    EaseMethod = EaseOutSine;
                    break;
                case EaseType.EaseInOutSine:
                    EaseMethod = EaseInOutSine;
                    break;
                case EaseType.EaseInQuad:
                    EaseMethod = EaseInQuad;
                    break;
                case EaseType.EaseOutQuad:
                    EaseMethod = EaseOutQuad;
                    break;
                case EaseType.EaseInOutQuad:
                    EaseMethod = EaseInOutQuad;
                    break;
                case EaseType.EaseInCubic:
                    EaseMethod = EaseInCubic;
                    break;
                case EaseType.EaseOutCubic:
                    EaseMethod = EaseOutCubic;
                    break;
                case EaseType.EaseInOutCubic:
                    EaseMethod = EaseInOutCubic;
                    break;
                case EaseType.EaseInQuart:
                    EaseMethod = EaseInQuart;
                    break;
                case EaseType.EaseOutQuart:
                    EaseMethod = EaseOutQuart;
                    break;
                case EaseType.EaseInOutQuart:
                    EaseMethod = EaseInOutQuart;
                    break;
                case EaseType.EaseInQuint:
                    EaseMethod = EaseInQuint;
                    break;
                case EaseType.EaseOutQuint:
                    EaseMethod = EaseOutQuint;
                    break;
                case EaseType.EaseInOutQuint:
                    EaseMethod = EaseInOutQuint;
                    break;
                case EaseType.EaseInExpo:
                    EaseMethod = EaseInExpo;
                    break;
                case EaseType.EaseOutExpo:
                    EaseMethod = EaseOutExpo;
                    break;
                case EaseType.EaseInOutExpo:
                    EaseMethod = EaseInOutExpo;
                    break;
                case EaseType.EaseInCirc:
                    EaseMethod = EaseInCirc;
                    break;
                case EaseType.EaseOutCirc:
                    EaseMethod = EaseOutCirc;
                    break;
                case EaseType.EaseInOutCirc:
                    EaseMethod = EaseInOutCirc;
                    break;
                case EaseType.EaseInBack:
                    EaseMethod = EaseInBack;
                    break;
                case EaseType.EaseOutBack:
                    EaseMethod = EaseOutBack;
                    break;
                case EaseType.EaseInOutBack:
                    EaseMethod = EaseInOutBack;
                    break;
                case EaseType.EaseInElastic:
                    EaseMethod = EaseInElastic;
                    break;
                case EaseType.EaseOutElastic:
                    EaseMethod = EaseOutElastic;
                    break;
                case EaseType.EaseInOutElastic:
                    EaseMethod = EaseInOutElastic;
                    break;
                case EaseType.EaseInBounce:
                    EaseMethod = EaseInBounce;
                    break;
                case EaseType.EaseOutBounce:
                    EaseMethod = EaseOutBounce;
                    break;
                case EaseType.EaseInOutBounce:
                    EaseMethod = EaseInOutBounce;
                    break;
                default:
                    break;
            }
        }
        public float EaseLinear(float time) {
            return time;
        }
        public float EaseInSine(float time) {
            return 1 - Mathf.Cos((time * Mathf.PI) / 2);
        }
        public float EaseOutSine(float time) {
            return Mathf.Sin((time * Mathf.PI) / 2);
        }
        public float EaseInOutSine(float time) {
            return -(Mathf.Cos(Mathf.PI * time) - 1) / 2;
        }
        public float EaseInQuad(float time) {
            return time * time;
        }
        public float EaseOutQuad(float time) {
            return 1 - (1 - time) * (1 - time);
        }
        public float EaseInOutQuad(float time) {
            return time < 0.5 ? 2 * time * time : 1 - Mathf.Pow(-2 * time + 2, 2) / 2;
        }
        public float EaseInCubic(float time) {
            return time * time * time;
        }
        public float EaseOutCubic(float time) {
            return 1 - Mathf.Pow(1 - time, 3);
        }
        public float EaseInOutCubic(float time) {
            return time < 0.5 ? 4 * time * time * time : 1 - Mathf.Pow(-2 * time + 2, 3) / 2;
        }
        public float EaseInQuart(float time) {
            return time * time * time * time;
        }
        public float EaseOutQuart(float time) {
            return 1 - Mathf.Pow(1 - time, 4);
        }
        public float EaseInOutQuart(float time) {
            return time < 0.5 ? 8 * time * time * time * time : 1 - Mathf.Pow(-2 * time + 2, 4) / 2;
        }
        public float EaseInQuint(float time) {
            return time * time * time * time * time;
        }
        public float EaseOutQuint(float time) {
            return 1 - Mathf.Pow(1 - time, 5);
        }
        public float EaseInOutQuint(float time) {
            return time < 0.5 ? 16 * time * time * time * time * time : 1 - Mathf.Pow(-2 * time + 2, 5) / 2;
        }
        public float EaseInExpo(float time) {
            return time == 0 ? 0 : Mathf.Pow(2, 10 * time - 10);
        }
        public float EaseOutExpo(float time) {
            return time == 1 ? 1 : 1 - Mathf.Pow(2, -10 * time);
        }
        public float EaseInOutExpo(float time) {
            return time == 0 ? 0 : time == 1 ? 1 : time < 0.5 ? Mathf.Pow(2, 20 * time - 10) / 2 : (2 - Mathf.Pow(2, -20 * time + 10)) / 2;
        }
        public float EaseInCirc(float time) {
            return 1 - Mathf.Sqrt(1 - Mathf.Pow(time, 2));
        }
        public float EaseOutCirc(float time) {
            return Mathf.Sqrt(1 - Mathf.Pow(time - 1, 2));
        }
        public float EaseInOutCirc(float time) {
            return time < 0.5 ? (1 - Mathf.Sqrt(1 - Mathf.Pow(2 * time, 2))) / 2 : (Mathf.Sqrt(1 - Mathf.Pow(-2 * time + 2, 2)) + 1) / 2;
        }
        public float EaseInBack(float time) {
            const float c1 = 1.70158f;
            const float c3 = c1 + 1f;
            return c3 * time * time * time - c1 * time * time;
        }
        public float EaseOutBack(float time) {
            const float c1 = 1.70158f;
            const float c3 = c1 + 1f;
            return 1 + c3 * Mathf.Pow(time - 1, 3) + c1 * Mathf.Pow(time - 1, 2);
        }
        public float EaseInOutBack(float time) {
            const float c1 = 1.70158f;
            const float c2 = c1 * 1.525f;
            return time < 0.5
               ? (Mathf.Pow(2 * time, 2) * ((c2 + 1) * 2 * time - c2)) / 2
               : (Mathf.Pow(2 * time - 2, 2) * ((c2 + 1) * (time * 2 - 2) + c2) + 2) / 2;
        }
        public float EaseInElastic(float time) {
            const float c4 = (2 * Mathf.PI) / 3;
            return time == 0
                ? 0
                : time == 1
                ? 1
                : -Mathf.Pow(2, 10 * time - 10) * Mathf.Sin((time * 10 - 10.75f) * c4);
        }
        public float EaseOutElastic(float time) {
            const float c4 = (2 * Mathf.PI) / 3;
            return time == 0
            ? 0
            : time == 1
            ? 1
            : Mathf.Pow(2, -10 * time) * Mathf.Sin((time * 10 - 0.75f) * c4) + 1;
        }
        public float EaseInOutElastic(float time) {
            const float c5 = (2 * Mathf.PI) / 4.5f;
            return time == 0
            ? 0
            : time == 1
            ? 1
            : time < 0.5
            ? -(Mathf.Pow(2, 20 * time - 10) * Mathf.Sin((20 * time - 11.125f) * c5)) / 2
            : (Mathf.Pow(2, -20 * time + 10) * Mathf.Sin((20 * time - 11.125f) * c5)) / 2 + 1;
        }
        public float EaseInBounce(float time) {
            return 1 - EaseOutBounce(1 - time);
        }
        public float EaseOutBounce(float time) {
            const float n1 = 7.5625f;
            const float d1 = 2.75f;
            if (time < 1 / d1) {
                return n1 * time * time;
            }
            else if (time < 2 / d1) {
                return n1 * (time -= 1.5f / d1) * time + 0.75f;
            }
            else if (time < 2.5 / d1) {
                return n1 * (time -= 2.25f / d1) * time + 0.9375f;
            }
            else {
                return n1 * (time -= 2.625f / d1) * time + 0.984375f;
            }
        }
        public float EaseInOutBounce(float time) {
            return time < 0.5 ? (1 - EaseOutBounce(1 - 2 * time)) / 2 : (1 + EaseOutBounce(2 * time - 1)) / 2;
        }
    }
    public class TweenParams {
        public string Id { get; set; }
        public int LoopCount { get; set; }
        public LoopType LoopType { get; set; }
        public Ease Ease { get; set; }
        public float DelayTime { get; set; }
        public TweenParams SetId(string id) {
            Id = id;
            return this;
        }

        public TweenParams SetDelay(float delay) {
            DelayTime = delay;
            return this;
        }

        public TweenParams SetLoop(int loopCount, LoopType loopType) {
            LoopCount = loopCount > 0 ? loopCount : int.MaxValue;  // -1 : infinite, > 0 : limited
            LoopType = loopType;
            return this;
        }
        public TweenParams SetEase(EaseType easeType) {
            var ease = new Ease();
            ease.SetEaseFunc(easeType);
            Ease = ease;
            return this;
        }
    }
    public abstract class Tween {
        protected abstract object Source { get; set; }
        protected abstract string Id { get; set; }
        protected abstract TweenType TweenType { get; set; }
        protected abstract bool IsTweenActive { get; set; }
        public abstract float timeScale { get; set; }
        protected abstract float Duration { get; set; }
        protected abstract float DelayTime { get; set; }
        protected abstract int LoopCount { get; set; }
        protected abstract LoopType LoopType { get; set; }
        protected abstract Ease Ease { get; set; }
        protected abstract bool IsRun { get; set; }
        protected abstract Action OnStartCallback { get; set; }
        protected abstract Action OnUpdateCallback { get; set; }
        protected abstract Action OnPlayCallback { get; set; }
        protected abstract Action OnPauseCallback { get; set; }
        protected abstract Action OnKillCallback { get; set; }
        protected abstract Action OnCompleteStepCallback { get; set; }
        protected abstract Action OnCompleteCallback { get; set; }
        public abstract bool IsActive();
        public abstract void Init();
        public abstract void Reset();
        public abstract void Reverse();
        public abstract Tween SetAs(TweenParams tweenParams);
        public abstract Tween SetId(string id);
        public abstract object GetSource();
        public abstract string GetId();
        public abstract float GetDelayTime();
        public abstract Tween SetDelay(float delay);
        public abstract Tween SetEase(EaseType easeType);
        public abstract Tween SetLoops(int loopCount, LoopType loopType);
        public abstract void Kill();
        public abstract Tween Pause();
        public abstract Tween Play();
        public abstract Tween OnStart(Action callBack);
        public abstract Tween OnPlay(Action callBack);
        public abstract Tween OnPause(Action callBack);
        public abstract Tween OnKill(Action callBack);
        public abstract Tween OnCompleteStep(Action callBack);
        public abstract Tween OnUpdate(Action callBack);
        public abstract Tween OnComplete(Action callBack);
        public abstract IEnumerator WaitForCompletion();
        public abstract void UpdateTween();
    }

    #region Generic Tweens
    public class GenericTween<T2, T3, T4> : Tween {
        protected override object Source { get; set; }
        protected override string Id { get; set; }
        protected override TweenType TweenType { get; set; }
        protected override bool IsTweenActive { get; set; }
        public override float timeScale { get; set; }
        public virtual T2 InitialValue { get; set; }
        public virtual T2 Target { get; set; }
        public virtual T3 Getter { get; set; }
        public virtual T4 Setter { get; set; }
        protected override float Duration { get; set; }
        protected override float DelayTime { get; set; }
        protected override int LoopCount { get; set; }
        protected override LoopType LoopType { get; set; }
        protected override Ease Ease { get; set; }
        protected override bool IsRun { get; set; }
        protected override Action OnStartCallback { get; set; }
        protected override Action OnUpdateCallback { get; set; }
        protected override Action OnPlayCallback { get; set; }
        protected override Action OnPauseCallback { get; set; }
        protected override Action OnKillCallback { get; set; }
        protected override Action OnCompleteStepCallback { get; set; }
        protected override Action OnCompleteCallback { get; set; }
        protected float tweenTime = 0;
        protected float delayTime = 0;
        protected bool isOnStartCallback = false;
        protected int loopCount = 0;
        public GenericTween(object source, T2 target, T3 getter, T4 setter, float duration) {
            Source = source;
            Target = target;
            Getter = getter;
            Setter = setter;
            Duration = duration;
            DelayTime = 0;
            LoopCount = 1;
            LoopType = LoopType.Restart;
            TweenType = TweenType.None;
            timeScale = 1;
            IsTweenActive = true;
            IsRun = true;
            Ease = new Ease();
            FLTween.Init();
            FLTween.tweens.Add(this);
        }
        public override bool IsActive() {
            return IsTweenActive;
        }
        public override void Init() { }
        public override void Reset() { }
        public override void Reverse() { }

        public override float GetDelayTime() {
            return DelayTime;
        }
        public override Tween SetAs(TweenParams tweenParams) {
            Ease = tweenParams.Ease;
            DelayTime = tweenParams.DelayTime;
            LoopType = tweenParams.LoopType;
            LoopCount = tweenParams.LoopCount;
            Id = tweenParams.Id;
            return this;
        }
        public override Tween SetId(string id) {
            Id = id;
            return this;
        }
        public override string GetId() {
            return Id;
        }
        public override object GetSource() {
            return Source;
        }
        public Tween SetTweenType(TweenType tweenType) {
            TweenType = tweenType;
            return this;
        }
        public TweenType GetTweenType() {
            return TweenType;
        }
        public override Tween SetDelay(float delay) {
            DelayTime = delay;
            return this;
        }
        public override Tween SetEase(EaseType easeType) {
            Ease.SetEaseFunc(easeType);
            return this;
        }
        public override Tween Pause() {
            if (IsRun) {
                IsRun = false;
                OnPauseCallback?.Invoke();
            }
            return this;
        }
        public override Tween SetLoops(int loopCount, LoopType loopType) {
            LoopCount = loopCount > 0 ? loopCount : int.MaxValue;  // -1 : infinite, > 0 : limited
            LoopType = loopType;
            return this;
        }
        public override Tween Play() {
            if (!IsRun) {
                IsRun = true;
                OnPlayCallback?.Invoke();
            }
            return this;
        }
        public override void Kill() {
            OnKillCallback?.Invoke();
            FLTween.tweens.Remove(this);
        }
        public override Tween OnStart(Action callBack) {
            OnStartCallback = callBack;
            isOnStartCallback = true;
            return this;
        }
        public override Tween OnPlay(Action callBack) {
            OnPlayCallback = callBack;
            return this;
        }
        public override Tween OnPause(Action callBack) {
            OnPauseCallback = callBack;
            return this;
        }
        public override Tween OnKill(Action callBack) {
            OnKillCallback = callBack;
            return this;
        }
        public override Tween OnCompleteStep(Action callBack) {
            OnCompleteStepCallback = callBack;
            return this;
        }
        public override Tween OnUpdate(Action callBack) {
            OnUpdateCallback = callBack;
            return this;
        }
        public override Tween OnComplete(Action callBack) {
            OnCompleteCallback = callBack;
            return this;
        }
        public override void UpdateTween() { }
        public override IEnumerator WaitForCompletion() {
            yield return new WaitForTween(() => IsTweenActive);
        }

    }
    public class GenericDummyTween : GenericTween<float, float, float> {

        public GenericDummyTween(object source, float target, float getter, float setter, float duration) : base(source, target, getter, setter, duration) {
            delayTime = 0;
        }
        public override void Reset() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
        }
        public override void Reverse() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
        }
        public override void UpdateTween() {
            if (delayTime < DelayTime) {
                delayTime += Time.deltaTime;
                return;
            }
            if (isOnStartCallback) {
                OnStartCallback?.Invoke();
                isOnStartCallback = false;
            }
            IsTweenActive = false;
            FLTween.tweens.Remove(this);

        }
    }
    public class GenericFloatTween : GenericTween<float, Func<float>, Func<float, float>> {

        protected float startValue;
        protected float targetValue;
        protected float distanceAmount;
        protected float preciseTarget;
        protected float stepAmount;
        protected bool isSet = false;

        public GenericFloatTween(object source, float target, Func<float> getter, Func<float, float> setter, float duration) : base(source, target, getter, setter, duration) {
            startValue = getter();
            targetValue = target;
            distanceAmount = targetValue - startValue;
        }

        public override void Init() {
            startValue = Getter();
            distanceAmount = targetValue - startValue;
            //Initial values for Sequences
            InitialValue = Getter();
            Target = targetValue;
        }
        public override void Reset() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
            startValue = InitialValue;
            targetValue = Target;
            distanceAmount = targetValue - startValue;
        }
        public override void Reverse() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
            (startValue, targetValue) = (targetValue, startValue);
            distanceAmount = targetValue - startValue;
        }
        public override void UpdateTween() {

            if (delayTime < DelayTime) {
                delayTime += Time.deltaTime;
                return;
            }
            if (!isSet) {
                Init();
                isSet = true;
            }

            if (isOnStartCallback) {
                OnStartCallback?.Invoke();
                isOnStartCallback = false;
            }

            if (loopCount < LoopCount) {
                if (tweenTime < 1f) {
                    if (IsRun) {
                        stepAmount = Ease.EaseMethod(tweenTime);
                        tweenTime += Time.deltaTime * timeScale / Duration;
                        Setter(startValue + stepAmount * distanceAmount);
                        OnUpdateCallback?.Invoke();
                    }
                }
                else {
                    loopCount++;
                    tweenTime = 0;
                    Setter(targetValue);
                    OnCompleteStepCallback?.Invoke();
                    if (LoopType == LoopType.Restart) {
                        if (loopCount < LoopCount - 1) {
                            Setter(targetValue);
                        }
                    }
                    else if (LoopType == LoopType.Incremental) {
                        if (loopCount < LoopCount) {
                            startValue = Getter();
                            targetValue = Getter() + distanceAmount;
                        }
                    }
                    else if (LoopType == LoopType.Yoyo) {
                        if (loopCount < LoopCount) {
                            startValue = Getter();
                            targetValue = startValue - distanceAmount;
                            distanceAmount = -distanceAmount;
                        }
                    }
                }
            }
            else {
                OnCompleteCallback?.Invoke();
                IsTweenActive = false;
                FLTween.tweens.Remove(this);
            }

        }
    }
    public class GenericVector3Tween : GenericTween<Vector3, Func<Vector3>, Func<Vector3, Vector3>> {
        protected Vector3 startValue;
        protected Vector3 targetValue;
        protected Vector3 distanceAmount;
        protected float stepAmount;
        protected Func<Vector3> targetUpdater;
        protected bool isSet = false;
        public GenericVector3Tween(object source, Vector3 target, Func<Vector3> getter, Func<Vector3, Vector3> setter, float duration, Func<Vector3> targetUpdater = null) : base(source, target, getter, setter, duration) {
            startValue = getter();
            targetValue = target;
            distanceAmount = targetValue - startValue;
            this.targetUpdater = targetUpdater;
        }

        public override void Init() {
            startValue = Getter();
            targetValue = targetUpdater != null ? targetUpdater() : targetValue;
            distanceAmount = targetValue - startValue;
            //Initial values for Sequences
            InitialValue = Getter();
            Target = targetValue;
        }
        public override void Reset() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
            startValue = InitialValue;
            targetValue = Target;
            distanceAmount = targetValue - startValue;
        }
        public override void Reverse() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
            (startValue, targetValue) = (targetValue, startValue);
            distanceAmount = targetValue - startValue;
        }
        public override void UpdateTween() {

            if (delayTime < DelayTime) {
                delayTime += Time.deltaTime;
                return;
            }
            if (!isSet) {
                Init();
                isSet = true;
            }

            if (isOnStartCallback) {
                OnStartCallback?.Invoke();
                isOnStartCallback = false;
            }

            if (loopCount < LoopCount) {
                if (tweenTime < 1f) {
                    if (IsRun) {
                        stepAmount = Ease.EaseMethod(tweenTime);
                        tweenTime += Time.deltaTime * timeScale / Duration;
                        Setter(startValue + stepAmount * distanceAmount);
                        OnUpdateCallback?.Invoke();
                    }
                }
                else {
                    loopCount++;
                    tweenTime = 0;
                    Setter(targetValue);
                    OnCompleteStepCallback?.Invoke();
                    if (LoopType == LoopType.Restart) {
                        if (loopCount < LoopCount - 1) {
                            Setter(targetValue);
                        }
                    }
                    else if (LoopType == LoopType.Incremental) {
                        if (loopCount < LoopCount) {
                            startValue = Getter();
                            targetValue = Getter() + distanceAmount;
                        }
                    }
                    else if (LoopType == LoopType.Yoyo) {
                        if (loopCount < LoopCount) {
                            startValue = Getter();
                            targetValue = startValue - distanceAmount;
                            distanceAmount = -distanceAmount;
                        }
                    }
                }
            }
            else {
                OnCompleteCallback?.Invoke();
                IsTweenActive = false;
                FLTween.tweens.Remove(this);
            }

        }
    }
    public class GenericVector2Tween : GenericTween<Vector2, Func<Vector2>, Func<Vector2, Vector2>> {
        protected Vector2 startValue;
        protected Vector2 targetValue;
        protected Vector2 distanceAmount;
        protected float stepAmount;
        protected Func<Vector2> targetUpdater;
        protected bool isSet = false;
        public GenericVector2Tween(object source, Vector2 target, Func<Vector2> getter, Func<Vector2, Vector2> setter, float duration, Func<Vector2> targetUpdater = null) : base(source, target, getter, setter, duration) {
            startValue = getter();
            targetValue = target;
            distanceAmount = targetValue - startValue;
            this.targetUpdater = targetUpdater;
        }
        public override void Init() {
            startValue = Getter();
            targetValue = targetUpdater != null ? targetUpdater() : targetValue;
            distanceAmount = targetValue - startValue;
            //Initial values for Sequences
            InitialValue = Getter();
            Target = targetValue;
        }

        public override void Reset() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
            startValue = InitialValue;
            targetValue = Target;
            distanceAmount = targetValue - startValue;
        }
        public override void Reverse() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
            (startValue, targetValue) = (targetValue, startValue);
            distanceAmount = targetValue - startValue;
        }
        public override void UpdateTween() {

            if (delayTime < DelayTime) {
                delayTime += Time.deltaTime;
                return;
            }
            if (!isSet) {
                Init();
                isSet = true;
            }

            if (isOnStartCallback) {
                OnStartCallback?.Invoke();
                isOnStartCallback = false;
            }

            if (loopCount < LoopCount) {
                if (tweenTime < 1f) {
                    if (IsRun) {
                        stepAmount = Ease.EaseMethod(tweenTime);
                        tweenTime += Time.deltaTime * timeScale / Duration;
                        Setter(startValue + stepAmount * distanceAmount);
                        OnUpdateCallback?.Invoke();
                    }
                }
                else {
                    loopCount++;
                    tweenTime = 0;
                    Setter(targetValue);
                    OnCompleteStepCallback?.Invoke();
                    if (LoopType == LoopType.Restart) {
                        if (loopCount < LoopCount - 1) {
                            Setter(targetValue);
                        }
                    }
                    else if (LoopType == LoopType.Incremental) {
                        if (loopCount < LoopCount) {
                            startValue = Getter();
                            targetValue = Getter() + distanceAmount;
                        }
                    }
                    else if (LoopType == LoopType.Yoyo) {
                        if (loopCount < LoopCount) {
                            startValue = Getter();
                            targetValue = startValue - distanceAmount;
                            distanceAmount = -distanceAmount;
                        }

                    }
                }
            }
            else {
                OnCompleteCallback?.Invoke();
                IsTweenActive = false;
                FLTween.tweens.Remove(this);
            }
        }
    }
    public class GenericRotateTween : GenericTween<Vector3, Func<Vector3>, Func<Vector3, Vector3>> {
        protected Vector3 startValue;
        protected Vector3 targetValue;
        protected Vector3 distanceAmount;
        protected Vector3 stepAmount;
        protected Func<Vector3> targetUpdater;
        protected bool isSet = false;
        public GenericRotateTween(object source, Vector3 target, Func<Vector3> getter, Func<Vector3, Vector3> setter, float duration, Func<Vector3> targetUpdater = null) : base(source, target, getter, setter, duration) {
            startValue = MapAngle360(getter());
            targetValue = MapAngle360(target);
            distanceAmount = FindShortestDistanceVector(startValue, targetValue);
            this.targetUpdater = targetUpdater;
        }
        public override void Init() {
            startValue = MapAngle360(Getter());
            targetValue = targetUpdater != null ? MapAngle360(targetUpdater()) : targetValue;
            distanceAmount = FindShortestDistanceVector(startValue, targetValue);
            //Initial values for Sequences
            InitialValue = startValue;
            Target = targetValue;
        }
        public override void Reset() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
            startValue = InitialValue;
            targetValue = Target;
            distanceAmount = targetValue - startValue;
        }
        public override void Reverse() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
            (startValue, targetValue) = (targetValue, startValue);
            distanceAmount = targetValue - startValue;
        }
        public override void UpdateTween() {


            if (delayTime < DelayTime) {
                delayTime += Time.deltaTime;
                return;
            }

            if (isOnStartCallback) {
                OnStartCallback?.Invoke();
                isOnStartCallback = false;
            }

            if (loopCount < LoopCount) {
                if (tweenTime < 1f) {
                    if (IsRun) {
                        tweenTime += Time.deltaTime * timeScale / Duration;
                        stepAmount.x = Ease.EaseMethod(tweenTime) * distanceAmount.x;
                        stepAmount.y = Ease.EaseMethod(tweenTime) * distanceAmount.y;
                        stepAmount.z = Ease.EaseMethod(tweenTime) * distanceAmount.z;
                        Setter(startValue + stepAmount);
                        OnUpdateCallback?.Invoke();
                    }
                }
                else {
                    loopCount++;
                    tweenTime = 0;
                    Setter(targetValue);
                    OnCompleteStepCallback?.Invoke();

                    if (LoopType == LoopType.Restart) {
                        if (loopCount < LoopCount - 1) {
                            Setter(targetValue);
                        }
                    }
                    else if (LoopType == LoopType.Incremental) {
                        if (loopCount < LoopCount) {
                            startValue = Getter();
                            targetValue = Getter() + distanceAmount;
                        }
                    }
                    else if (LoopType == LoopType.Yoyo) {
                        if (loopCount < LoopCount) {
                            startValue = Getter();
                            targetValue = startValue - distanceAmount;
                            distanceAmount = -distanceAmount;
                        }
                    }
                }
            }
            else {
                OnCompleteCallback?.Invoke();
                IsTweenActive = false;
                FLTween.tweens.Remove(this);
            }
        }
        private Vector3 MapAngle360(Vector3 angle) {
            Vector3 temp = new Vector3(angle.x % 360, angle.y % 360, angle.z % 360);
            return temp;
        }
        private Vector3 FindShortestDistanceVector(Vector3 start, Vector3 target) {
            Vector3 temp;
            temp.x = FindShortestAngularDistance(start.x, target.x);
            temp.y = FindShortestAngularDistance(start.y, target.y);
            temp.z = FindShortestAngularDistance(start.z, target.z);
            return temp;
        }
        private float FindShortestAngularDistance(float start, float target) {
            if (start - target >= -180 && start - target <= 0) {
                return -(start - target);
            }
            else if (start - target < -180 && start - target > -360) {
                return -(360 + (start - target));
            }
            else if (start - target <= 180 && start - target >= 0) {
                return -(start - target);
            }
            else if (start - target > 180 && start - target < 360) {
                return (360 - (start - target));
            }
            else {
                return 0;
            }
        }
    }
    public class GenericColorTween : GenericTween<Color, Func<Color>, Func<Color, Color>> {
        protected Vector4 startValue;
        protected Vector4 targetValue;
        protected Vector4 distanceAmount;
        protected Vector4 stepAmount;
        protected Func<Vector4> targetUpdater;
        protected bool isSet = false;
        public GenericColorTween(object source, Color target, Func<Color> getter, Func<Color, Color> setter, float duration, Func<Vector4> targetUpdater = null) : base(source, target, getter, setter, duration) {
            startValue = getter();
            targetValue = target;
            distanceAmount = targetValue - startValue;
            this.targetUpdater = targetUpdater;
        }
        public override void Init() {
            startValue = Getter();
            targetValue = targetUpdater != null ? targetUpdater() : targetValue;
            distanceAmount = targetValue - startValue;
            //Initial values for Sequences
            InitialValue = Getter();
            Target = targetValue;
        }
        public override void Reset() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
            startValue = InitialValue;
            targetValue = Target;
            distanceAmount = targetValue - startValue;
        }
        public override void Reverse() {
            tweenTime = 0;
            delayTime = 0;
            loopCount = 0;
            IsTweenActive = true;
            (startValue, targetValue) = (targetValue, startValue);
            distanceAmount = targetValue - startValue;
        }
        public override void UpdateTween() {

            if (delayTime < DelayTime) {
                delayTime += Time.deltaTime;
                return;
            }

            if (isOnStartCallback) {
                OnStartCallback?.Invoke();
                isOnStartCallback = false;
            }

            if (loopCount < LoopCount) {
                if (tweenTime < 1f) {
                    if (IsRun) {
                        tweenTime += Time.deltaTime * timeScale / Duration;
                        stepAmount = Ease.EaseMethod(tweenTime) * distanceAmount;
                        Setter(new Color(startValue.x + stepAmount.x, startValue.y + stepAmount.y, startValue.z + stepAmount.z, startValue.w + stepAmount.w));
                        OnUpdateCallback?.Invoke();
                    }
                }
                else {
                    loopCount++;
                    tweenTime = 0;
                    Setter(new Color(targetValue.x, targetValue.y, targetValue.z, targetValue.w));
                    OnCompleteStepCallback?.Invoke();

                    if (LoopType == LoopType.Restart) {
                        if (loopCount < LoopCount - 1) {
                            Setter(targetValue);
                        }
                    }
                    else if (LoopType == LoopType.Incremental) {
                        if (loopCount < LoopCount) {
                            startValue = Getter();
                            targetValue = (Vector4)Getter() + distanceAmount;
                        }
                    }
                    else if (LoopType == LoopType.Yoyo) {
                        if (loopCount < LoopCount) {
                            startValue = Getter();
                            targetValue = startValue - distanceAmount;
                            distanceAmount = -distanceAmount;
                        }
                    }
                }
            }
            else {
                OnCompleteCallback?.Invoke();
                IsTweenActive = false;
                FLTween.tweens.Remove(this);
            }
        }
    }

    #endregion
    #region Custom Yield Instructions
    public class WaitForTween : CustomYieldInstruction {
        Func<bool> isTweenActive;
        public WaitForTween(Func<bool> predicate) {
            isTweenActive = predicate;
        }
        public override bool keepWaiting {
            get
            {
                return isTweenActive();
            }
        }
    }
    #endregion
}


