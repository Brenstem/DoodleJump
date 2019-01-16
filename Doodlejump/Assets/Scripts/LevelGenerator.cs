using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject block;
    [SerializeField] GameObject powerup;
    [SerializeField] GameObject enemy;
    [SerializeField] float minY;
    [SerializeField] float maxY;
    [SerializeField] float levelWidth;
    [SerializeField] [Range(0, 1)] float powerupSpawnChance;
    [SerializeField] [Range(0, 1)] float enemySpawnChance;

    void Start()
    {
        Vector2 startPos = new Vector2();

        for (int i = 0; i < 200; i++)
        {
            minY += 0.01f;
            startPos.y += Random.Range(minY, maxY);
            startPos.x = Random.Range(-levelWidth / 2, levelWidth / 2);
            Instantiate(block, startPos, Quaternion.identity, block.transform.parent);

            if (Random.Range(0f, 1f) < powerupSpawnChance)
            {
                Vector2 powerupStartPos = new Vector2(startPos.x, startPos.y += 0.5f);
                Instantiate(powerup, startPos, Quaternion.identity, powerup.transform.parent);
            }

            if (Random.Range(0f,1f) < enemySpawnChance)
            {
                Vector2 enemyStartPos = new Vector2(startPos.x, startPos.y += 1);
                Instantiate(enemy, enemyStartPos, Quaternion.identity, enemy.transform.parent);
            }
        }
    }
}
