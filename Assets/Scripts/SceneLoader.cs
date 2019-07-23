using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2f;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("LoadFirstScene", levelLoadDelay);
    }

    // Update is called once per frame
    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
