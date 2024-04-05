using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour

{
    public Health PlayerHealth;

    public GameObject PickupEffect;

    [SerializeField] GameObject powerUp;
    
    void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        if (other.CompareTag("Player"))
        { 
            Pickup();

            PlayerHealth = other.gameObject.GetComponent<Health>();
            StartCoroutine(NoDamage());
        }
    }
 
    void Pickup()
    {
        
    }

    private IEnumerator NoDamage() 
    {
        Debug.Log ("Health Disabled " + PlayerHealth.HP);
        PlayerHealth.HP = 5;
        powerUp.GetComponent<SpriteRenderer>().enabled = false;
        PlayerHealth.IsInvincible = true;

        yield return new WaitForSeconds(5);
       
        Debug.Log ("Health Enabled " + PlayerHealth.HP);
        PlayerHealth.IsInvincible = false;
        Destroy(gameObject);
    }
}
