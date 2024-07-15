using System.Collections;
using UnityEngine;

public class PinHolder : MonoBehaviour
{
    private Transform[] pins = new Transform[10];
    private bool allPinsFall = false;

    private void Start()
    {
        for(int i=0; i<transform.childCount; i++)
        {
            pins[i] = transform.GetChild(i);
        }
    }

    private void Update()
    {
        allPinsFall = true;
        for (int i = 0; i < pins.Length; i++)
        {
            if(pins[i].rotation == Quaternion.identity)
            {
                allPinsFall = false;
            }
        }
        if (allPinsFall)
        {
            StartCoroutine("RespawnPins");
        }
    }

    private IEnumerator RespawnPins()
    {
        yield return new WaitForSeconds(5);

        GetComponentInParent<PinSpawner>().RespawnPins();
    }
}
