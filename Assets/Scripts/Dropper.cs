using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mr;
    Rigidbody rb;

    [SerializeField] int secondsToWait = 3;

    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        mr.enabled = false;
        rb.useGravity = false;
    }

    void Update()
    {
        if(Time.time > secondsToWait)
        {
            mr.enabled = true;
            rb.useGravity = true;
        }
    }
}
