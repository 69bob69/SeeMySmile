using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changefaces : MonoBehaviour
{
    public GameObject head1;
    public GameObject head2;
    public GameObject head3;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        head1.SetActive(true);
        head2.SetActive(false);
        head3.SetActive(false);
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(ButtonClicked);
    }

    public void ButtonClicked() {
        head1.SetActive(false);
        head2.SetActive(true);
        head3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            head1.SetActive(true);
            head2.SetActive(false);
            head3.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.W)){
            head1.SetActive(false);
            head2.SetActive(true);
            head3.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.E)){
            head1.SetActive(false);
            head2.SetActive(false);
            head3.SetActive(true);
        }
    }
}
