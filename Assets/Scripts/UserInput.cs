using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ThreeDShell {
    public class UserInput : MonoBehaviour
    {
	private Vector2 pointerPosition;
	// Start is called before the first frame update
	void Start()
	{
	    
	}
	
	// Update is called once per frame
	void Update()
	{
	    
	}
	
	void OnPoint(InputValue value) {
	    pointerPosition = value.Get<Vector2>();
	}
	
	void OnPushed() {
	    Ray ray = Camera.main.ScreenPointToRay(new Vector3(pointerPosition.x, pointerPosition.y, 0));
	    RaycastHit hit;
	    
	    if (Physics.Raycast(ray, out hit)) {
		File file = hit.collider.gameObject.GetComponent<File>();
		Directory directory = hit.collider.gameObject.GetComponent<Directory>();
		if (file == null && directory == null)
		    return;
		
		file?.OnClicked();
		directory?.OnClicked();
	    }
	}
    }
}
