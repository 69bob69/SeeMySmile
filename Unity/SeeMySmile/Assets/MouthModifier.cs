using UnityEngine;
using UnityEngine.UI;

public class MouthModifier : MonoBehaviour
{
    public float blendShapeIndex;
    public Slider slider;
    private SkinnedMeshRenderer skinnedMeshRenderer;

    public void Start()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    public void SetBlendShapeIndex(int index)
    {
        blendShapeIndex = index;
    }

    public void OnSliderValueChanged(float value)
    {
        skinnedMeshRenderer.SetBlendShapeWeight((int)blendShapeIndex, value);
    }
}
