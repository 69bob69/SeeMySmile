using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using BlendShapesEnum = BlendShapes.Enums.BlendShapes;


public class MultiFeatures : MonoBehaviour
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

    public void OnSliderValueChanged(float value)
    {
        skinnedMeshRenderer.SetBlendShapeWeight((int)BlendShapesEnum.BrowsD_L, value);
        skinnedMeshRenderer.SetBlendShapeWeight((int)BlendShapesEnum.BrowsD_R, value);
        skinnedMeshRenderer.SetBlendShapeWeight((int)BlendShapesEnum.BrowsU_C, value);
        skinnedMeshRenderer.SetBlendShapeWeight((int)BlendShapesEnum.BrowsU_L, value);
    }
}




