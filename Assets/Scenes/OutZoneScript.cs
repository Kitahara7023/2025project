using UnityEngine;

public class OutZoneScript : MonoBehaviour
{
    public Rigidbody SphereRB;
    public Transform SphereTF;

    bool isTimeStart = false;
    float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimeStart) timer += Time.deltaTime;

        if (timer > 2 )
        {
            ReTry();
        }
    }
    void ReTry()
    {
        //ballRB.linearVelocity = new Vector3(0, 0, 0);
        SphereTF.transform.position = new Vector3(5, 29f, 0);
        SphereRB.useGravity = true;
        isTimeStart = false;
        timer = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTimeStart = true;
            other.transform.position = new Vector3(0, -1000, -1000);
            SphereRB.useGravity = false;
            SphereRB.linearVelocity = new Vector3(0, 0, 0);
        }
    }
}
