using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using BlendShapesEnum = BlendShapes.Enums.BlendShapes;

public class HappyEyes : MonoBehaviour
{
    public GameObject skinnedMeshObject;
    public Slider slider;

    private SkinnedMeshRenderer skinnedMeshRenderer;

    void Start()
    {
        skinnedMeshRenderer = skinnedMeshObject.GetComponent<SkinnedMeshRenderer>();
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    public void OnSliderValueChanged(float value)
    {   
        /*float BrowsD_L_weight = 0.373f * value;
        float BrowsD_R_weight = 0.35f * value;
        float BrowsU_C_weight = 0.182f * value;
        float BrowsU_L_weight = 0.27f * value;
        float BrowsU_R_weight = 0.287f * value;
        float EyeSquint_L_weight = 0.486f * value;
        float EyeSquint_R_weight = 0.504f * value;*/

        skinnedMeshRenderer.SetBlendShapeWeight((int)BlendShapesEnum.BrowsD_L, value); // 37.3
        skinnedMeshRenderer.SetBlendShapeWeight((int)BlendShapesEnum.BrowsD_R, value); // 35
        skinnedMeshRenderer.SetBlendShapeWeight((int)BlendShapesEnum.BrowsU_C, value); // 18.2
        skinnedMeshRenderer.SetBlendShapeWeight((int)BlendShapesEnum.BrowsU_L, value); // 12.7
        skinnedMeshRenderer.SetBlendShapeWeight((int)BlendShapesEnum.BrowsU_R, value); // 28.7
        skinnedMeshRenderer.SetBlendShapeWeight((int)BlendShapesEnum.EyeSquint_L, value); // 48.6
        skinnedMeshRenderer.SetBlendShapeWeight((int)BlendShapesEnum.EyeSquint_R, value); // 50.4
    }
}




