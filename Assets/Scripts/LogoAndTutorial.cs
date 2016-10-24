using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LogoAndTutorial : MonoBehaviour {

    [SerializeField]
    private float waitTime = 5;

    [SerializeField] private GameObject logoVideo = null;
    [SerializeField] private GameObject tutorialVideo = null;
    void Start()
    {
        StartCoroutine(Delay());
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(waitTime);
        if (logoVideo != null)
        {
            logoVideo.SetActive(false);
        }
        if (!tutorialVideo != null)
        {
            tutorialVideo.SetActive(true);
        }
        yield return new WaitForSeconds(6.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
