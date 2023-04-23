using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public float moveSpeed = 5.0f;

    void Start()
    {
        
    }

     void Update()
    {

        Quaternion targetRotation = Quaternion.LookRotation(Player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1 * Time.deltaTime);
        transform.position += transform.forward * moveSpeed * Time.deltaTime;

    }



}

