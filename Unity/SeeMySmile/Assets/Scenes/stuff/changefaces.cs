using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changefaces : MonoBehaviour
{
    public GameObject head1;
    public GameObject head2;
    public GameObject head3;
    // Start is called before the first frame update
    void Start()
    {
        head1.SetActive(true);
        head2.SetActive(false);
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
