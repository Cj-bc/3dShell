using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Hud : MonoBehaviour
{
    public Text pwdText;
    public Shell shell;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        pwdText.text = shell.pwd.info.FullName + ": " + shell.pwd.info.Name;
    }
}
