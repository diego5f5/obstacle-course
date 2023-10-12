using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = new Color(1, 0, 0, 1);
            gameObject.tag = "Hit";
        }
    }
}
