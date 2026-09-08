using UnityEngine;
using TMPro;
using UnityEngine.Events;


public class Player : MonoBehaviour
{
    public int health = 6;
    private TMP_Text healthLabel;
    public UnityEvent onGameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthLabel = GetComponentInChildren<TMP_Text>();
        healthLabel.text = health.ToString();
    }

    void LoseHealth(int amount)
    {
        health -= amount;

        if(health <= 0)
        {
            health = 0;
            onGameOver.Invoke();
        }

        healthLabel.text = health.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Enemy"))
        {
            LoseHealth(collision.gameObject.GetComponent<Enemy>().health);
            Destroy(collision.gameObject);
        }
    }
}
