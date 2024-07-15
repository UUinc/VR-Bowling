using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Ball : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Release() 
    {
        rb.AddForce(rb.velocity * speed, ForceMode.Impulse);
    }
}
