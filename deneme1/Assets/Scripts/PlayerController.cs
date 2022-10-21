using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public bool carpma;
    void Start()
    {
        rb=GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch dokunus = Input.GetTouch(0);
            if (dokunus.phase == TouchPhase.Began)
            {
                carpma = true;
            }
            if(dokunus.phase == TouchPhase.Ended)
            {
                carpma = false;
            }
        }
        //if (Input.GetMouseButtonDown(0))
        //{
           
        //}
        //if(Input.GetMouseButtonUp(0))
        //{
        //    carpma = false;
        //}

    }
    private void FixedUpdate()
    {
        if (carpma)
        {
            rb.velocity = new Vector3 (0,-100*Time.fixedDeltaTime*7,0);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!carpma)
        {
            rb.velocity=new Vector3 (0,50*Time.deltaTime*5,0);

        }

    }
    private void OnCollisionStay(Collision collision)
    {
        if (!carpma)
        {
            rb.velocity = new Vector3(0, 50 * Time.deltaTime * 5, 0);

        }

    }
}
