using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadOnlyInInspectorExample : MonoBehaviour
{
    [SerializeField, ReadOnlyInInspector] private int intType = 1;
    [SerializeField, ReadOnlyInInspector] private float floatType = 2.99f;
    [SerializeField, ReadOnlyInInspector] private string stringType = "hello";
    [SerializeField, ReadOnlyInInspector] private bool boolType = true;

    [SerializeField, ReadOnlyInInspector] private ColorSpace enumType = ColorSpace.Gamma;

    [SerializeField, ReadOnlyInInspector] private Vector2 vector2Type = Vector2.one;
    [SerializeField, ReadOnlyInInspector] private Vector3 vector3Type = Vector3.one;
    [SerializeField, ReadOnlyInInspector] private Vector4 vector4Type = Vector4.one;

    [SerializeField, ReadOnlyInInspector] private List<int> listType = new List<int> {1, 2, 3};
}
