using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
  /*  public GameObject backPrefab;
    private GameObject[] bcks;
    public float pivotPoint;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bcks = new GameObject[3];
        for(int i = 0; i < 3; i++){
            float xPos = pivotPoint - (pivotPoint / 2 * i);
            float yPos = pivotPoint -  (pivotPoint /2 * i);
            Vector2 position = new Vector2(xPos, yPos);
            bcks[i] = Instantiate(backPrefab, position, Quaternion.identity);
         } 
        
    }

    // Update is called once per frame
    void Update()
    {
        for(i = 0; i < 3; i++){
            float xPos = bcks[i].transform.position.x + speed;
            float yPos = bcks[i].transform.position.y + speed;
            Vector2 position = new Vector2(xPos, yPos);
            if (bcks[i].transform.position.x > -pivotPoint/2){
                position = new Vector2(pivotPoint, pivotPoint);
            }
            bcks[i].transform.position = position;
        }
    }*/
}
