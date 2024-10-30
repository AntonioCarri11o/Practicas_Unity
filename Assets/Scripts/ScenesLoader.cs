using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{

    public Slider progressBar;
    public TextMeshProUGUI loadText;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("LoadScene", "RedBallScene");
        LoadScence(PlayerPrefs.GetString("LoadScene"));
    }

    public void LoadScence(string sceneName)
    {
        StartCoroutine(loadSceneWithProgress(sceneName));
    }

    private IEnumerator loadSceneWithProgress(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            if (progressBar != null)
            {
                progressBar.value = progress;
            }

            if(loadText != null)
            {
                loadText.text = "Loading... " + (progress * 100f).ToString("F0") + "%";
            }
            yield return null;
        }
    }
}
