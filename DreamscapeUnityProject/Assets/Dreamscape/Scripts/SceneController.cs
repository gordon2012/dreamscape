using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

    GameObject gameController;
    GameController gcScript;

    GameObject player;

    void Awake()
    {
        gameController = GameObject.Find("GameController");
        gcScript = gameController.GetComponent<GameController>();
        
        player = GameObject.FindGameObjectWithTag("Player");
    }

	// Use this for initialization
	void Start ()
    {

        GameObject[] nodes = GameObject.FindGameObjectsWithTag("Respawn");

        foreach (GameObject n in nodes)
        {
            SpawnPoint spScript = n.GetComponent<SpawnPoint>();
            if (spScript.nodeID == gcScript.targetNode)
            {
                //player = Instantiate
                player.transform.position = n.transform.position;
                break;
            }
        }


	    //player = Instantiate
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
