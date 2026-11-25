using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(Physics.Raycast(transform.position, transform.up)) {
            GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
