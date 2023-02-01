using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(ShowOnPause.instance == null)
        {
            SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
