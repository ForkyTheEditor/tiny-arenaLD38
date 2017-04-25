using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    private Text txt;

    private void Start()
    {
        txt = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        txt.text = PlayerStats.currentHP.ToString();
	}
}
