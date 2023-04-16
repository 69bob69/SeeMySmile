using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouthSmile : MonoBehaviour
{
    public GameObject skinnedMeshObject;
    public float smileValue;
    public Slider slider;

    private SkinnedMeshRenderer skinnedMeshRenderer;

    void Start()
    {
        skinnedMeshRenderer = skinnedMeshObject.GetComponent<SkinnedMeshRenderer>();
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    void OnSliderValueChanged(float value)
    {
        skinnedMeshRenderer.SetBlendShapeWeight(59, value);
    }
}


