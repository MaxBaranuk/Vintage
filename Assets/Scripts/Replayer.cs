using UnityEngine;
using System.Collections;

public class Replayer : MonoBehaviour
{

    [SerializeField]
    private MediaPlayerCtrl sphere = null;

    public void Replay()
    {
        sphere.Stop();
        StartCoroutine(ReplayVideo());
    }

    private IEnumerator ReplayVideo()
    {
        yield return new WaitForSeconds(2);
        sphere.Play();
    }
}
