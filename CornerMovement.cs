using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerMovement : MonoBehaviour
{
   // public GameObject myQuad;
    // public bool isBool = true;
    // public float speed;

    public GameObject myQuad;
    public Vector2 myQuadPosition;

    public int mynInt, maxxInt;
    public float myyFloat;
    public float mySpeed;
    public bool lowerLimitReached = true;
   // public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        myQuad.transform.position = new Vector2(0, 0);

       // MyFirstFunction();
    }

    // Update is called once per frame
    void Update()
    {
        /*  if (isBool == true)
          {
              myQuad.transform.position = new Vector2(-4f , 0);

          }

          else if (myQuad.transform.position.x == -4f)
          {
              myQuad.transform.position = new Vector2(4, 0);
          }*/

        /*  if(myQuad.transform.position.x == 0)
          {
              myQuad.transform.position = new Vector2(2 , 0) * speed ;
          }

          if(myQuad.transform.position.x == 4)
          {
              myQuad.transform.position = new Vector2(-2, 0) * speed;
          }*/

        MyFirstFunction();

    }

    public void MyFirstFunction()
    {

          if (lowerLimitReached == true)
          {

              myyFloat = Mathf.MoveTowards(myyFloat, maxxInt, mySpeed * Time.deltaTime);

              if (myyFloat >= 4f)
              {
                  lowerLimitReached = false;

              }

          }

          else if (lowerLimitReached == false)
          {
              myyFloat = Mathf.MoveTowards(myyFloat, mynInt, mySpeed * Time.deltaTime);

              if (myyFloat <= -4f )
              {
                  lowerLimitReached = true;

              }

          }

          myQuadPosition = new Vector2(myyFloat, myQuad.transform.position.y);
          myQuad.transform.position = myQuadPosition; 

    }
}
