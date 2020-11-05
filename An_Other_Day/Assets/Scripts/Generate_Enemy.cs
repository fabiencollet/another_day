using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate_Enemy : MonoBehaviour
{
    public GameObject Enemy;
    [SerializeField] public float xPos;
    [SerializeField] public float zPos;

    [SerializeField] public float enemyCount = 0;
    // Start is called before the first frame update
    void Update()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        if (enemyCount < 10)
        {
            xPos = Random.Range(-23, 30);
            zPos = Random.Range(29, 116);

            Instantiate(Enemy, new Vector3(xPos, -1, zPos), Quaternion.identity);

            yield return new WaitForSeconds(0.1f);

            enemyCount += 1;

            Debug.Log("Je spawn un zombie");
        }
        
    }
}
