using UnityEngine;
using UnityEngine.InputSystem;



public class NewMonoBehaviourScript : MonoBehaviour{

    public float timeout;
    public float timeStart;
    public float timeThusFar;
    public GameObject gameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeStart = Time.time; //get current time
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision){
        string tag = collision.gameObject.tag;
        Debug.Log("You've entered the trigger of: " + collision.gameObject.tag);
        if(collision.gameObject.CompareTag("Top")){
            Debug.Log("Game over Timer started at: " + timeStart);
            timeStart = Time.time; //Get current Time
        }
        
    }

    public void OnTriggerStay2D(Collider2D collision){
        string tag = collision.gameObject.tag;
        Debug.Log("Trigger stay on:" + collision.gameObject.tag);
        if(tag.Equals("Top")){
        timeThusFar = Time.time - timeStart;
        Debug.Log("Game over Timer updated: " + timeThusFar);
        if(timeThusFar >= timeout){
            Debug.Log("Game over");
            }
        }
    }
}
