using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitCount = 0;

    void OnCollisionEnter(Collision other)
    {
        if(!other.gameObject.CompareTag("Hit"))
        {
            hitCount++;
            Debug.Log("You've bumped into a thing this many times: " + hitCount);
        }
        

    }
}
