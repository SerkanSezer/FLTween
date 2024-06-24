using FLTweening;
using UnityEngine;

public class FLTweenExamples : MonoBehaviour {
    [SerializeField] private Transform _targetObject;
    [SerializeField] private Vector3 _targetPos;
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _tweenDuration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _loopCount;
    [SerializeField] private EaseType _easeType;

    void Update() {
        if (Input.GetKeyDown(KeyCode.M)) {
            transform.FLMove(_targetPos, _tweenDuration).SetLoops(_loopCount, _loopType).SetEase(_easeType);
        }
        else if (Input.GetKeyDown(KeyCode.L)) {
            transform.FLLookAt(_targetObject.position, _tweenDuration).SetEase(_easeType);
        }
        else if (Input.GetKeyDown(KeyCode.C)) {
            transform.GetComponent<MeshRenderer>().material.FLColor(_targetColor, _tweenDuration).SetEase(_easeType).SetLoops(_loopCount, _loopType);
        }
    }
}
