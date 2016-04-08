using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {

    public string startScene;
    public int targetNode;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene(startScene);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadScene(string tScene, int tNode)
    {
        targetNode = tNode;
        SceneManager.LoadScene(tScene);
    }
}
