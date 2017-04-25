using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrosshairCursorFollow : MonoBehaviour
{

    public Image img;

    private void Update()
    {
        if(Time.timeScale == 1f)
        {
            img.rectTransform.position = Input.mousePosition;
        }
        

    }
}
