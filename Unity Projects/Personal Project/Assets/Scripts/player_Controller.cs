using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class player_Controller : MonoBehaviour
{
    public float speed = 10f;
    public float horizontalInput;
    public float xRange = 50;
    public float zRange = 10;
    public int maxHealth = 100;
    public int currentHealth;
    private Rigidbody rigid;
    public int PlayerHealth = 100;

    void Start()
    {
        currentHealth = maxHealth;
        rigid = GetComponent<Rigidbody>();
    }
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            death();
        }
    }
    public void death()
    {
        Destroy(gameObject);
        Debug.Log("DEATH");
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if(transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);

    }
}
