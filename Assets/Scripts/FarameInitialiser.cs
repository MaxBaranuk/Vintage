using UnityEngine;
using System.Collections;

public class FarameInitialiser : MonoBehaviour
{
    [SerializeField] private GameObject frame = null;
    [SerializeField] private GameObject videoPlane = null;

    private void Start()
    {
        StartCoroutine(ShowFrame());
    }

    private IEnumerator ShowFrame()
    {
        yield return new WaitForSeconds(6);
        if (videoPlane != null)
            videoPlane.SetActive(false);
        if (frame != null)
            frame.SetActive(true);
    }
}
