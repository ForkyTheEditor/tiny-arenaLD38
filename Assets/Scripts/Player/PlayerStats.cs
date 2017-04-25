using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {


    public int maxHP;
    public static int currentHP;
    private bool played = false;
    
    
    public AudioSource deathSource;
    public AudioSource musicSource;
    public Slider volume;

    public Text txt;
    private GameObject sceneManager;
    private GameObject deathCanvas;

    private void Start()
    {
        currentHP = maxHP;
        played = false;
        sceneManager = GameObject.Find("SceneManager");
        deathCanvas = sceneManager.GetComponent<SceneManager>().deathCanvas;
    }

    private void Update()
    {
        deathSource.volume = volume.value;

        if (currentHP <= 0)
        {
            PlayerWeaponSlot.isDead = true;
            currentHP = 0;
            Die();
        }
    }

    private void Die()
    {
        if(deathCanvas != null)
        {
            Cursor.visible = true;
            if (!played)
            {
                musicSource.Stop();
                deathSource.Play();
                played = true;
            }
            txt.text = "You have lasted " + RoundSpawning.roundNumber + " rounds";
            deathCanvas.SetActive(true);
        }
        
    }
}
