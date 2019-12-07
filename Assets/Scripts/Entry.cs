using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Type;

public class Entry : MonoBehaviour
{
    public string path;
    public string name;
    public Entry  parent;
    public byte permission;
    public System.DateTime lastTouched;
    public GameObject model;
}
