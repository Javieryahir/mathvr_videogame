using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float shootingSpeed = 10f;
    public GameObject mainCamera;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Vector3 shootingDirection = mainCamera.transform.forward;
        Vector3 arrowPosition = mainCamera.transform.position;
         Quaternion arrowRotation = Quaternion.LookRotation(shootingDirection);

         arrowRotation *= Quaternion.Euler(90, 0, 0);

        GameObject arrow = Instantiate(arrowPrefab, arrowPosition, arrowRotation);
        Rigidbody arrowRigidbody = arrow.GetComponent<Rigidbody>();
        
        if (arrowRigidbody != null)
        {
            arrowRigidbody.velocity = shootingDirection * shootingSpeed;
        }
    }
}
