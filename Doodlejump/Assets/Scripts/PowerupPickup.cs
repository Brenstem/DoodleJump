using UnityEngine;

public class PowerupPickup : MonoBehaviour
{
    enum Powerups
    {
        JumpBoost,
        Helicopter
    } 

    [SerializeField] Powerups currentPowerup;

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
                default:
                    break;
            }

            Destroy(this.gameObject);
        }
    }
}
