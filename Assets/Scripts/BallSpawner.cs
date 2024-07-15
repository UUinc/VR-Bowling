using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject Ball;

    private void Start()
    {
        StartCoroutine(SpawnBallByTime(0f));
        StartCoroutine(SpawnBallByTime(1f));
        StartCoroutine(SpawnBallByTime(2f));
        StartCoroutine(SpawnBallByTime(3f));
        StartCoroutine(SpawnBallByTime(4f));
    }

    public void SpawnBall()
    {
        GameObject tmpBall = Instantiate(Ball, transform);
        tmpBall.GetComponent<Rigidbody>().AddForce(-Vector3.forward * 10f, ForceMode.Impulse);
    }

    private IEnumerator SpawnBallByTime(float time)
    {
        yield return new WaitForSeconds(time);
        SpawnBall();
    }
}
