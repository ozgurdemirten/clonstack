using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    private Vector3 cameraposition;
    private Transform player, win;
    private float cameraOff=4f;
    // Start is called before the first frame update
    private void Awake()
    {
        player = FindObjectOfType<PlayerController>().transform;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (win == null) { 
           // win=GameObject.Find("win(clone)").GetComponent<Transform>();
        
        }
        if (transform.position.y > player.position.y && transform.position.y > win.position.y + cameraOff)
        {
            cameraposition = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = new Vector3(transform.position.x, cameraposition.y, -5);
        }









    }
}
