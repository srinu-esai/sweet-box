using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour
{
    public float movementSpeed = 5;
    public float rotationSpeed = 5;
    // private GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;
        float rotZ = transform.eulerAngles.z;
        if (Input.GetKey(KeyCode.D))
        {
            if (posX < 8)
            {
                posX += 1 * movementSpeed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (posX > -8)
            {
                 posX -= 1 * movementSpeed * Time.deltaTime;
                
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (posY < 4.3)
            {
                posY += 1 * movementSpeed * Time.deltaTime;

            }
        }
        if (Input.GetKey(KeyCode.S))
        {


            if (posY > -4.3)
            {
                posY -= 1 * movementSpeed * Time.deltaTime;
            }
        }

       

        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            if (rotZ >= 270 || rotZ <= 100) 
            {
                rotZ -= 10 * rotationSpeed * Time.deltaTime;
            }

            transform.rotation = Quaternion.Euler(new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, rotZ));
        }

        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            if (rotZ >= 260 || rotZ <= 90)
            {
                rotZ += 10 * rotationSpeed * Time.deltaTime;

            }
            transform.rotation = Quaternion.Euler(new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, rotZ));
        }

        //Debug.Log("Rotation: " + transform.rotation);
        //Debug.Log("EulateEngles: " + transform.eulerAngles);
        //transform.Rotate(0, 0, -10, Space.Self);


        Vector2 movement = new Vector2(posX, posY);
            transform.position = movement;
             
        
    }
}
