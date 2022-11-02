using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaintainScale : MonoBehaviour
{
    private Vector3 originalScale;
    private Vector3 parentOriginalScale;

    private void Awake()
    {
        // afaik RectTransform inherits from Transform 
        // so this should also work for UI objects.

        originalScale = transform.localScale;

        parentOriginalScale = transform.parent.localScale;
    }

    private void LateUpdate()
    {
        var currentParentScale = transform.parent.localScale;

        // Get the relative difference to the original scale
        var diffX = currentParentScale.x / parentOriginalScale.x;
        var diffY = currentParentScale.y / parentOriginalScale.y;
        var diffZ = currentParentScale.z / parentOriginalScale.z;

        // This inverts the scale differences
        var diffVector = new Vector3(1 / diffX, 1 / diffY, 1 / diffZ);

        // Apply the inverted differences to the original scale
        transform.localScale = Vector3.Scale(originalScale, diffVector);
    }
}
