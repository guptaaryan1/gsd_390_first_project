using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeOnCollisionWithPlane : MonoBehaviour
{
    [SerializeField] // attribute color
    private Color color = Color.green;
    private MeshRenderer meshrenderer;
    // Update is called once per frame
    void Update()
    {
        float normalizedHeight = Mathf.InverseLerp(1f, 1.67f, transform.position.y); // using static class math
        GetComponent<MeshRenderer>().material.color = Color.Lerp(Color.blue, Color.red, normalizedHeight); ; // generics passed in GetComponent<T>

    }
}
