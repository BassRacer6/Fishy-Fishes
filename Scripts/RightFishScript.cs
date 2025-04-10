using UnityEngine;

public class RightFishScript : MonoBehaviour
{
    public EnemyScript enemyScript;
    void Start()
    {
        enemyScript = GetComponent<EnemyScript>();
    }
    void Update()
    {
        if (enemyScript.imAlive)
        {
            transform.position += (Vector3.left * enemyScript.moveSpeed) * Time.deltaTime;
        }
    }
}
