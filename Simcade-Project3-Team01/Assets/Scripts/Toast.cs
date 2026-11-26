using UnityEngine;

public class Toast : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForceAtPosition(force, Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
