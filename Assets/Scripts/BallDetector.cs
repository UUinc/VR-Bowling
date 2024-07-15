using System.Collections;
using UnityEngine;

public class BallDetector : MonoBehaviour
{
    public Transform BallSpawner;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            StartCoroutine(MoveBall(2f));
        }
    }

    private IEnumerator MoveBall(float time)
    {
        yield return new WaitForSeconds(time);
        BallSpawner.GetComponent<BallSpawner>().SpawnBall();
    }
}
