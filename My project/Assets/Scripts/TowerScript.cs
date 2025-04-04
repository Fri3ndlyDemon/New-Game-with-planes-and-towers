using UnityEngine;

public class TowerScript : MonoBehaviour
{

    public float movespeed = 1.0f;
    public float destruct = -25.0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * movespeed * Time.deltaTime;

        if(transform.position.x < destruct)
        {
            Debug.Log("Destroyed");
            Destroy(gameObject);
        }
            
    }
}
