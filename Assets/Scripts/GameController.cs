using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Vector3 positionAsteroid;
    public GameObject asteroid;
    public int hazardCount;
    public float startWait;
    public float spawnWait;
    public float waitForWaves;

    private void Start() {
        StartCoroutine(spawnWaves());
    }

    private IEnumerator spawnWaves(){
        yield return new WaitForSeconds(startWait);
        while(true){
            for (int i = 0; i < hazardCount;i++){
                Vector3 position = new Vector3(Random.Range(-positionAsteroid.x, positionAsteroid.x), positionAsteroid.y, positionAsteroid.z);
                Quaternion rotation = Quaternion.identity;
                Instantiate(asteroid, position, rotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waitForWaves);
        }
    }

}
