using UnityEngine;

public class ShowOnPause : MonoBehaviour
{
    public static ShowOnPause instance;

    [SerializeField]
    bool showOnStart = false;

    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = gameObject.GetComponent<Canvas>();
        canvas.enabled = showOnStart;

        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.enabled = !canvas.enabled;
        }
    }
}
