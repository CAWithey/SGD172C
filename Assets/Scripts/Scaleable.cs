using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaleable : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localScale = transform.localScale;
    }
}
