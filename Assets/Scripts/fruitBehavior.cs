using UnityEngine;
using UnityEngine.InputSystem;



public class fruitBehavior : MonoBehaviour{

//     public float timeout;
    public int treatType;
    public GameObject[] treats;
//     public float timeStart;
//     public float timeThusFar;
//     public GameObject gameOver;


    //Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        treats = GameObject.FindGameObjectWithTag("Player").GetComponent<playerBehavior>().treats;
    }

     // Update is called once per frame
    void Update()
     {
        
     }

    private void OnCollisionEnter2D(Collision2D other){

        if (other.gameObject.CompareTag("Treat")){
            int otherType = other.gameObject.GetComponent<fruitBehavior>().treatType;
            if (otherType == treatType && treatType < 9) {

                if (gameObject.transform.position.x < other.transform.position.x
                    || gameObject.transform.position.x == other.transform.position.x
                        && gameObject.transform.position.y >= other.transform.position.y) {
                            
                            //create the merged one   

                            int index = treatType +1;
                            GameObject currentTreat = Instantiate(treats[index], 
                            Vector3.Lerp(gameObject.transform.position,other.gameObject.transform.position, 0.5f), Quaternion.identity);
                            currentTreat.GetComponent<Collider2D>().enabled = true;
                            currentTreat.GetComponent<Rigidbody2D>().gravityScale = 1.0f;

                            //destroy both things

                            Destroy(other.gameObject);
                            Destroy(gameObject);

                }
            }
        }
    }











//    /* private void OnTriggerEnter2D(Collider2D other){
//         if(other.gameObject.CompareTag("Top")){
//             timeStart = Time.time;
//         }
//     }

//     private void OnTriggerEnter2D(Collider2D other){
//         if(other.gameObject.CompareTag("Top")){
//             float currentTime = Time.time;
//             float timeThusFar = currentTime - timeStart;
//             if(timeThusFar > timeout){}
//             print("game over dude");
//         }
//     }*/

//     public void OnTriggerEnter2D(Collider2D collision){
//         string tag = collision.gameObject.tag;
//         Debug.Log("You've entered the trigger of: " + collision.gameObject.tag);
//         if(collision.gameObject.CompareTag("Top")){
//             Debug.Log("Game over Timer started at: " + timeStart);
//             timeStart = Time.time; //Get current Time
//         }
        
//     }

//     public void OnTriggerStay2D(Collider2D collision){
//         string tag = collision.gameObject.tag;
//         Debug.Log("Trigger stay on:" + collision.gameObject.tag);
//         if(tag.Equals("Top")){
//         timeThusFar = Time.time - timeStart;
//         Debug.Log("Game over Timer updated: " + timeThusFar);
//         if(timeThusFar >= timeout){

//             Debug.Log("Game over");
//             }
//         }
//     }
}
