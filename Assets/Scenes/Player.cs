using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] bool orbit;
    
    public float speed = 1f; 
    public float radius = 1f; 

    private Vector3 center; 
    private float angle;

    private void Start()
    {
        orbit = true;
        center = transform.position;
    }

    private void Update()
    {
        if (orbit)
        {
            angle += speed * Time.deltaTime; 
            float x = Mathf.Sin(angle) * radius;
            float y = 0f;
            float z = Mathf.Cos(angle) * radius; 
            transform.position = center + new Vector3(x, y, z); 
        }
    }
}
