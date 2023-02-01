using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoad : MonoBehaviour
{
    [SerializeField]
    GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < objects.Length; i++)
        {
            DontDestroyOnLoad(objects[i]);
        }

        Destroy(gameObject);

        int sceneCount = SceneManager.sceneCount;

        for(int i = 0; i < sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if(scene.name == "PauseMenu")
            {
                SceneManager.UnloadSceneAsync(scene);
            }
        }
    }

}
