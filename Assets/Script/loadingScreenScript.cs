using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingScreenScript : MonoBehaviour
{
    private AsyncOperation loadAsync;

    void Start()
    {
        loadAsync = SceneManager.LoadSceneAsync(3);
        loadAsync.allowSceneActivation = false;

        StartCoroutine(load());
    }

    IEnumerator load()
    {
        yield return new WaitForSeconds(2f);
        loadAsync.allowSceneActivation = true;
    }
}
