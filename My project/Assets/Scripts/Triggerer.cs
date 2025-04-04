using UnityEngine;

public class Triggerer : MonoBehaviour
{
    public GameManager gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            gm.scorer();
        }        
    }
}
