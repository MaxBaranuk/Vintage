using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitialSceneManager : MonoBehaviour
{
    private AsyncOperation mainScene;

    private void Start()
    {
        mainScene = SceneManager.LoadSceneAsync("Main");
        mainScene.allowSceneActivation = false;
    }

    public void LoadMainScene()
    {
        StopAllCoroutines();
        StartCoroutine(Wait());
    }

    public void CancelLoad()
    {
        StopAllCoroutines();
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        mainScene.allowSceneActivation = true;
    }
}
