using UnityEngine;
using System.Collections;

public class TelePoint : MonoBehaviour {

    public string targetScene;
    public int targetNode;

    GameObject gameController;
    //GameController gcScript;

    void Awake()
    {
        gameController = GameObject.Find("GameController");
        //gcScript = gameController.GetComponent<GameController>();

        //player = GameObject.FindGameObjectWithTag("Player");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        // player.transform.position = target.transform.position;
        //SceneManager.LoadScene("scene2");
        gameController.GetComponent<GameController>().LoadScene(targetScene, targetNode);
    }


}
