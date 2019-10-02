using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBasketScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Foods")
        {
            //other.transform.parent = this.transform.root;
            other.transform.parent = this.transform;
            other.transform.localPosition = this.transform.localPosition;
            other.transform.localScale = other.transform.parent.parent.localScale;
            other.transform.localRotation = other.transform.localRotation;
            //var child[] = other.
            //print(this.transform.parent);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Foods")
        {
            other.transform.parent = null;
        }
    }
}