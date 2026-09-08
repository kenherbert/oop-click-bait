using UnityEngine;

public class BossEnemy : Enemy
{
    public string message = "Time to die, Mr. Blob!";

    protected override void Start()
    {
        base.Start();
        healthLabel.text = message;
    }
    public override void Move()
    {
        direction = transform.position - Vector3.zero;
        Vector3 rotatedDirection = Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.forward) * direction;
        transform.position = rotatedDirection;
    }
}
