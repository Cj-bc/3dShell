using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Type

public class Entry : MonoBehaviour
{
    public string name;
    public Entry  parent;
    public byte permission;
    public DateTime lastTouched;
    public Prefab model;
}
