//using UnityEngine.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerBehavior : MonoBehaviour
{
    public float speed;
    public GameObject treat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {

        //dropping fruit
       /*if (treat = null ){
            Vector3 treatOffset = new Vector3(0.0f, -1.0f, 0.0f);
            treat.transform.position = gameObject.transform.position + treatOffset;
          //  treat.GetComponent<Rigidbody2D>().gravity.Scale = 0.0f;
            treat.GetComponent<Collider2D>.enabled = false;

        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame){
            //treat.GetComponent<Rigidbody2D>().gravity.Scale = 1.0f;
            treat.GetComponent<Collider2D>().enabled = true;
            treat = null;
        }
*/
        //movement
        float update = 0.0f;
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame) {
            update = -speed;
        }

        if (Keyboard.current.rightArrowKey.wasPressedThisFrame) {
            update = +speed;
        }

        Vector3 newPosition = transform.position;
        newPosition.x = transform.position.x + update;
        transform.position = newPosition;
    }
}
