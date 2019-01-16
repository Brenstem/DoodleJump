using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] int healthPoints;

    public int hp { get { return healthPoints; } set { healthPoints = value; } }
    private bool mCanDie = true;
    public bool CanDie { get { return mCanDie; } set { mCanDie = value; } }

    public void TakeDamage(int dmg)
    {
        hp -= dmg;
        if (hp <= 0 && CanDie)
            Die();
    }

    private void Die()
    {
        if (transform.gameObject.CompareTag("Player"))
        {
            transform.gameObject.SetActive(false);

            if (Application.CanStreamedLevelBeLoaded("GameOver"))
            {
                SceneManager.LoadScene("GameOver");
            }
        }

        else
        {
            Destroy(this.gameObject);
        }
    }
}
