using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLogic : MonoBehaviour {

    public Button button;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClicked()
    {
        Debug.Log("Clicked");
    }

    public void OnPointerEnter()
    {
        Debug.Log("OnPointerEnter");
        ColorBlock cb = button.colors;
        cb.normalColor = new Color(3F, 169F, 244F, 255F);
        button.colors = cb;
    }

    public void OnPointerExit()
    {
        Debug.Log("OnPointerExit");
        ColorBlock cb = button.colors;
        cb.normalColor = new Color(255F, 255F, 255F, 255F);
        button.colors = cb;
    }
}
