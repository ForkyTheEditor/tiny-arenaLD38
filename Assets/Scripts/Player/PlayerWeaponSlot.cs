using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWeaponSlot : MonoBehaviour
{
    
    public GameObject bullet;
    public GameObject normalBullet;
    private Camera mainCamera;
    public float shootDelay;
    private float timer;
    public static bool isDead = false;

    public Text txt;

    public float upgradeDelay;
    private float upgradeTimer;

    private void Start()
    {
        isDead = false;
        mainCamera = FindObjectOfType<Camera>();
        timer = shootDelay;
        upgradeTimer = upgradeDelay;
    }

    private void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        timer -= Time.deltaTime;

        if(bullet != normalBullet)
        {
            upgradeTimer -= Time.deltaTime;

            txt.text = "Upgrade duration: " + Mathf.Round((upgradeTimer * 10))/10;
            if(upgradeTimer <= 0)
            {
                bullet = normalBullet;
                upgradeTimer = upgradeDelay;
                txt.text = "";
            }
        }

        if (groundPlane.Raycast(ray, out rayLength) && Time.timeScale == 1 && !isDead)
        {
            Vector3 pointToLookAt = ray.GetPoint(rayLength);
            transform.LookAt(pointToLookAt);
            Debug.DrawRay(ray.origin, pointToLookAt, Color.blue);
        }

        if (Input.GetMouseButton(0) && Time.timeScale == 1f && timer <= 0)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            timer = shootDelay;
        }

    }

}
