using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TestScript : MonoBehaviour
{

    [SerializeField, Tooltip("回転させたい対象")] Transform target = default;

    void Start()
    {
        target
            .DOLocalRotate(new Vector3(0.0f, 360.0f, 0.0f), 1.0f)
            .SetRelative(true)
            .SetLoops(-1);
    }
}
