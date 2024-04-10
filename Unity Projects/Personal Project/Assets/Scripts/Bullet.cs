using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    private Vector3 moveDirection;
    public float time_alive;

    private void Start()
    {
        Invoke("DestroyBullet", time_alive);
    }

    public void Seek(Transform _target)
    {
        target = _target;
        if (target != null)
        {
            moveDirection = (target.position - transform.position).normalized;
        }
        else
        {
            moveDirection = transform.forward;
        }
    }

    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player_Controller playerHealth = collision.gameObject.GetComponent<player_Controller>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(20); 
            }
            
            Destroy(gameObject);
        }
    }
}

