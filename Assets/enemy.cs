using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float rotationspeed;
    public float distance;


    public LineRenderer lineofsight;
    public Gradient redcolor;
    public Gradient greencolor;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //transform.Rotate(Vector3.forward * rotationspeed * Time.deltaTime);
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position,-transform. up, distance);
        Debug.DrawRay(transform.position, -transform.up);

        if (hitinfo.collider != null)
        {

            Debug.Log("I hit something" + hitinfo.collider.gameObject.name);

            Debug.DrawLine(transform.position, hitinfo.point, Color.red);
            lineofsight.SetPosition(0, hitinfo.point);
            if (hitinfo.collider.gameObject.tag == "Player")
            {
                lineofsight.colorGradient = greencolor;
                //Destroy(hitinfo.collider.gameObject);
            }
            else
            {
                lineofsight.colorGradient = redcolor;
            }
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + -transform.up * distance, Color.green);
                float right = 0;
                lineofsight.SetPosition(1,transform.position  + -transform.up  * distance);
                //lineofsight.colorGradient 

        }
    }

    private void Destory(object gameobject)
    {
        throw new NotImplementedException();
    }
}
