using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalEmotion : MonoBehaviour
{
    public TMP_Dropdown masterDropdown;
    public TMP_Dropdown[] linkedDropdowns;

    public void Start()
    {
        masterDropdown.onValueChanged.AddListener(delegate {
            OnMasterDropdownValueChanged(masterDropdown);
        });
    }

    public void OnMasterDropdownValueChanged(TMP_Dropdown master)
    {
        int index = master.value;
        foreach (TMP_Dropdown dropdown in linkedDropdowns)
        {
            dropdown.value = index;
        }
    }
}

