using UnityEngine;

public class AreaDamage : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] bool damageEnvironment;
    [SerializeField] bool destroyOnContact;

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.GetComponent<Health>() != null)
        {
            hitInfo.GetComponent<Health>().TakeDamage(damage);
        }
        else if (damageEnvironment)
        {
            Destroy(hitInfo.gameObject);
        }
        if (destroyOnContact)
        {
            Destroy(this.gameObject);
        }
    }
}
