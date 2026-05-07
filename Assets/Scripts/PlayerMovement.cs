using UnityEngine;


public class PlayerMovement : MonoBehaviour

{

    public float MovementSpeed = 1f;


    private void Update()

    {

        //Left - Right Movement

        var movementx = Input.GetAxis("Horizontal");

        var movementy = Input.GetAxis("Vertical");

        transform.position += new Vector3(movementx, movementy, 0) * Time.deltaTime * MovementSpeed;



        //Crouching and shifting

        if (Input.GetKey("left ctrl"))

        {

            MovementSpeed = 2;

        }

        else if (Input.GetKey("left shift"))

        {

            MovementSpeed = 10;

        }

        else

        {

            MovementSpeed = 5;

        }

    }

}
