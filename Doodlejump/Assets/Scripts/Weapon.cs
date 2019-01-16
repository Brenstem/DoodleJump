using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Transform firepoint;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float fireRate;
    [SerializeField] bool autoFire;

    public bool canFire = true;

    private float fireTimer = 0;
    private Vector2 firePosition;

    private void Update()
    {
        if (canFire)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (canFire)
        {
            fireTimer += Time.deltaTime;

            if (!autoFire)
            {
                float fire = Input.GetAxisRaw("Fire1");

                if (fire == 1 && fireTimer > fireRate)
                {
                    Instantiate(bulletPrefab, firepoint.position, Quaternion.identity);
                    fireTimer = 0;
                }
            }
            else if (autoFire)
            {
                if (fireTimer > fireRate)
                {
                    Instantiate(bulletPrefab, firepoint.position, Quaternion.identity);
                    fireTimer = 0;
                }
            }
        }
    }
}
