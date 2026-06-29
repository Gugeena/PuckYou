using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadMainMenuScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(load());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator load()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(1);
    }
}
