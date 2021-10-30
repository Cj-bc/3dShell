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
        OnPwdChanged();

	shell.OnPwdChanged.AddListener(OnPwdChanged);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPwdChanged() {
        pwdText.text = shell.pwd.info.Name;
    }
}
