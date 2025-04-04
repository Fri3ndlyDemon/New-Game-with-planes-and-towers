using UnityEngine;

public class TowerCreation : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;

    public float offset = 0;
    void Start()
    {
        pipecreation();
    }

    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            pipecreation();
            timer = 0;
        }
            
    }
    void pipecreation()
    {
        float lpoint = transform.position.y - offset;
        float hpoint = transform.position.y + offset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lpoint,hpoint), 0), transform.rotation);
    }
}
