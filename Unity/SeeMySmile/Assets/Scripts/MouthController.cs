using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MouthController : MonoBehaviour
{
    public GameObject skinnedMeshObject;
    public TMP_Dropdown dropdown;
    public Slider slider;

    private SkinnedMeshRenderer skinnedMeshRenderer;
    private MouthModifier mouthModifier;

    public void Start()
    {
        skinnedMeshRenderer = skinnedMeshObject.GetComponent<SkinnedMeshRenderer>();
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);

        // Get a reference to the MouthModifier component and pass the necessary objects to its Start() method
        mouthModifier = GetComponent<MouthModifier>();
        if (mouthModifier == null)
        {
            Debug.LogError("MouthModifier not found!");
            return;
        }

        mouthModifier.slider = slider;
        mouthModifier.Start();
        dropdown.SetValueWithoutNotify(0);
    }


    public void OnDropdownValueChanged(int index)
    {
        // TO DO
        // keeping these lines of code prevent the app from crashing - need to understand why?
        if (mouthModifier == null) 
        {
            // Debug.LogError("MouthModifier is null!");
            return;
        }

        // Set the blend shape index based on the selected option in the dropdown
        switch(index)
        {
            case 0:
                mouthModifier.SetBlendShapeIndex(59);
                break;
            case 1:
                mouthModifier.SetBlendShapeIndex(50);
                break;
            default:
                Debug.LogError("Invalid blend shape index!");
                break;
        }
    }


    public void OnSliderValueChanged(float value)
    {
        Debug.Log("Slider value changed: " + value);
        if (mouthModifier == null)
        {
            Debug.LogError("MouthModifier is null!");
            return;
        }

        // Call the OnSliderValueChanged method in the MouthModifier component
        mouthModifier.OnSliderValueChanged(value);
    }


}
