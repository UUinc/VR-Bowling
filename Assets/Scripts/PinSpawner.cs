using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public GameObject PinsPrefab;

    private GameObject PinHolder = null;

    private void Start()
    {
        if (transform.childCount == 0)
        {
            RespawnPins();
        }
    }

    public void RespawnPins()
    {
        if(PinHolder != null)
        {
            Destroy(PinHolder);
        }

        PinHolder = Instantiate(PinsPrefab, transform);
    }
}
