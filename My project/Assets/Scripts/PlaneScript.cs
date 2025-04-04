using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    public Rigidbody2D planerigid;
    public GameManager gm;

    private bool planecrashed = false;


    public float force = 5.0f;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !planecrashed)
        {
            planerigid.linearVelocity = Vector2.up * force;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        gm.towover();
        planecrashed = true;
    }
}
