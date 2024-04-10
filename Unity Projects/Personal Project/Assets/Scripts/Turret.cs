using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform target;
    public float range = 10f;
    public float turnSpeed = 10f;
    public float fireCooldown = 2f; // Cooldown time between shots
    private float fireCooldownTimer = 0f; // Timer to track cooldown

    public GameObject bulletPrefab;
    public Transform firePoint;

    private void Update()
    {
        if (target == null)
        {
            FindTarget();
            return;
        }

        // Look at the target
        Vector3 direction = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Vector3 rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        // Update the fire cooldown timer
        fireCooldownTimer -= Time.deltaTime;

        // Check if the target is in range and cooldown time has passed
        if (direction.magnitude <= range && fireCooldownTimer <= 0f)
        {
            // Fire bullet
            Fire();
            // Reset the fire cooldown timer
            fireCooldownTimer = fireCooldown;
        }
    }

    void FindTarget()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
    }

    void Fire()
    {
        // Instantiate bullet
        GameObject bulletGO = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.Seek(target);
        }
    }
}