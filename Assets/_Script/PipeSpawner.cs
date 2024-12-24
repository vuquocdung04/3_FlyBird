using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject prefab0;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;

    public float sizeSpawn = 5;
    public List<GameObject> spawnList;

    private void Start()
    {
        InvokeRepeating(nameof(PipeSpawn),1f,1.75f);

    }
    void PipeSpawn()
    {

        if (spawnList.Count >= sizeSpawn)
        {
            return;
        }
        int ramdomPipe = Random.Range(0, 4);
        float ramdomPos = Random.Range(-2f, 2.5f);

        switch (ramdomPipe)
        {
            case 0:
                var obj0 = Instantiate(prefab0, new Vector2(this.transform.position.x, ramdomPos), Quaternion.identity, this.transform);
                spawnList.Add(obj0);
                break;
            case 1:
                var obj1 = Instantiate(prefab1, new Vector2(this.transform.position.x, ramdomPos), Quaternion.identity, this.transform);
                spawnList.Add(obj1);
                break;
            case 2:
                var obj2 = Instantiate(prefab2, new Vector2(this.transform.position.x, ramdomPos), Quaternion.identity, this.transform);
                spawnList.Add(obj2);
                break;
            case 3:
                var obj3 = Instantiate(prefab3, new Vector2(this.transform.position.x, ramdomPos), Quaternion.identity, this.transform);
                spawnList.Add(obj3);
                break;
        }


    }
}
