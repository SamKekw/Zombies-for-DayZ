using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Zombie : MonoBehaviour
{
    public Rigidbody Zombierigidbody;
    public float speed = 5;
    public float ZombieHP = 10;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Zombierigidbody = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
           {
           // other.gameObject.GetComponent<player>().TakeDamage();
            Debug.Log("Hit: " + other);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // transform.LookAt(Player.transform);
       // Zombierigidbody.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);

    }

    
}


