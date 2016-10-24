using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TutorialLevelLoader : MonoBehaviour
{

    [SerializeField] private float waitTime = 5;
	void Start ()
	{
	    StartCoroutine(WaitAndLoadTutorial());
	}

    private IEnumerator WaitAndLoadTutorial()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.UnloadScene(SceneManager.GetActiveScene());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
