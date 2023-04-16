using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoSomethingAfterTenSeconds());
    }

    IEnumerator DoSomethingAfterTenSeconds()
    {
        yield return new WaitForSeconds(5);

        // now do something
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
