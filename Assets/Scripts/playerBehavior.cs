//using UnityEngine.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerBehavior : MonoBehaviour
{
    public float speed;
    public GameObject[] treats;
    public GameObject currentTreat;
    public float min; //-2.432
    public float max; //6.285

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {

        //dropping fruit
       if (currentTreat != null ) {
            Vector3 treatOffset = new Vector3(0.0f, -1.0f, 0.0f);
            currentTreat.transform.position = gameObject.transform.position + treatOffset;
            currentTreat.GetComponent<Rigidbody2D>().gravityScale = 0.0f;
            //currentTreat.GetComponent<PolygonCollider2D>().enabled = false;
            } else {
                int index = Random.Range(0, treats.Length);
                currentTreat = Instantiate(treats[index], transform.position, Quaternion.identity);
            }
        

        if (Keyboard.current.spaceKey.wasPressedThisFrame){
            currentTreat.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
            currentTreat.GetComponent<PolygonCollider2D>().enabled = true;
            currentTreat = null;
        }

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
        if(newPosition.x > min && newPosition.x < max){
        transform.position = newPosition;
        }
    }
}
