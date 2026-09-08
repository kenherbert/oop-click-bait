using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int health;

    protected Vector3 direction;
    private TMP_Text healthLabel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = Vector3.zero - transform.position;
        healthLabel = GetComponentInChildren<TMP_Text>();
        healthLabel.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public virtual void Move()
    {
        transform.position += direction.normalized * speed * Time.deltaTime;
    }

    public void ChangeHealth(int diff)
    {
        health += diff;
        healthLabel.text = health.ToString();

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}
