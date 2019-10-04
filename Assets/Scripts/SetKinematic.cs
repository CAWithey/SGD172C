using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetKinematic : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        //rb.isKinematic = true;
        if (name == "Crab(Clone)")
        {
            transform.Rotate(270f, 0f, 0f, Space.Self);
        }
        if (name == "Ice Cream Bar(Clone)" || name == "Ice Cream Cone(Clone)" || name == "Ice Cream Swirl(Clone)" || name == "Watermelon(Clone)")
        {
            transform.Rotate(0f, 0f, 90f, Space.Self);
        }
    }
    private void OnCollisionEnter()
    {
        if (rb.isKinematic == true)
        {
            rb.isKinematic = false;
        }
    }
}
