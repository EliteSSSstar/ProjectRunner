
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    //Veriables
    GroundSpawner groundSpawner;

    public GameObject[] obstaclePrefabs;
    public Transform[] spawnPoints;


    private void Awake(){
         //returns Ground so when player reaches spawner a floor will generate infront of them.
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnObs();
            
    }


    void OnTriggerExit (Collider other)
    {
            
        groundSpawner.SpawnTile();
        //destroy objects/floor after few second
        Destroy(gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObs()
    {
        //random generter of 3 spawnpoints 
        int ChooseSpawnPoint = Random.Range(0,spawnPoints.Length);
        int SpawnPrefab = Random.Range(0,obstaclePrefabs.Length);

        Instantiate(obstaclePrefabs[SpawnPrefab],spawnPoints[ChooseSpawnPoint].transform.position,Quaternion.identity, transform);
    }
}
