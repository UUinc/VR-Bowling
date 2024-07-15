using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject Ball;

    private void Start()
    {
        GameObject tmpBall = Instantiate(Ball, transform);
        tmpBall.GetComponent<Rigidbody>().AddForce(Vector3.forward, ForceMode.Impulse);
    }
}
