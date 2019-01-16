using UnityEngine;

public class PowerupPickup : MonoBehaviour
{
    enum Powerups
    {
        JumpBoost = 0,
        Helicopter = 1,
        Shoot = 2
    } 

    [SerializeField] Powerups currentPowerup;
    [SerializeField] bool autopickPowerup;

    private void Start()
    {
        if (autopickPowerup)
        {
            int  amountOfPowerups = Powerups.GetNames(typeof(Powerups)).Length;
            int random = Random.Range(0, amountOfPowerups);

            currentPowerup = (Powerups)random;
        }
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.CompareTag("Player"))
        {
            StatePatternPlayer player = hitInfo.GetComponent<StatePatternPlayer>();
            switch (currentPowerup)
            {
                case Powerups.JumpBoost:
                    player.ChangeState(player.jumpBoost);
                    break;
                case Powerups.Helicopter:
                    player.ChangeState(player.helicopter);
                    break;
                case Powerups.Shoot:
                    player.ChangeState(player.shootState);
                    break;
                default:
                    break;
            }

            Destroy(this.gameObject);
        }
    }
}
