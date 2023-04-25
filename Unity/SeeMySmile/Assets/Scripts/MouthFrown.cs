using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouthFrown : MonoBehaviour
{
    public GameObject skinnedMeshObject;
    public float frownValue;
    public Slider slider;

    private SkinnedMeshRenderer skinnedMeshRenderer;

    void Start()
    {
        skinnedMeshRenderer = skinnedMeshObject.GetComponent<SkinnedMeshRenderer>();
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    void OnSliderValueChanged(float value)
    {
        skinnedMeshRenderer.SetBlendShapeWeight(50, value);
    }
}


