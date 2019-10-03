using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBasketScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Foods")
        {
            print(other.transform.parent);
            if (other.transform.parent == null)
            {
                other.transform.parent = this.transform.parent;
            }
            print(other.transform.parent);
            other.transform.localScale = other.transform.localScale;
            //other.transform.parent = this.transform;
            //ChangeParentScale(this.transform, transform.localScale);
            //other.transform.localScale = this.transform.parent.parent.localScale;
            //other.transform.localRotation = this.transform.parent.parent.localRotation;
            //other.transform.localPosition = this.transform.localPosition;
            //other.transform.parent = this.transform.root;
            //other.transform.SetParent(transform, false);
            //other.gameObject.transform.GetChild(0) = this.gameObject.transform;
            //other.transform.localPosition = this.transform.localPosition;
            //other.transform.localScale = other.transform.parent.parent.localScale;
            //other.transform.localRotation = other.transform.localRotation;
            //var child[] = other.
            //print(this.transform.parent);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Foods")
        {
            other.transform.localScale = other.transform.localScale;
            other.transform.localRotation = other.transform.localRotation;
            other.transform.parent = null;
        }
    }

    void ChangeParentScale(Transform parent, Vector3 scale)
    {
        List<Transform> children = new List<Transform>();
        foreach (Transform child in parent)
        {
            child.parent = null;
            children.Add(child);
        }
        parent.localScale = scale;
        foreach (Transform child in children) child.parent = parent;
    }
}