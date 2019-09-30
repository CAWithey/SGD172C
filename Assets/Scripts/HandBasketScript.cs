using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBasketScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Foods")
        {
            //other.transform.parent = this.transform.parent;
            other.transform.localPosition = this.transform.localPosition;
            other.transform.localRotation = this.transform.localRotation;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Foods")
        {
            other.transform.localPosition = other.transform.localPosition;
            other.transform.localRotation = other.transform.localRotation;
        }
    }
}