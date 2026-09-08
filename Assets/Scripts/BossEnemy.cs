using UnityEngine;

public class BossEnemy : Enemy
{
    public override void Move()
    {
        direction = transform.position - Vector3.zero;
        Vector3 rotatedDirection = Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.forward) * direction;
        transform.position = rotatedDirection;
    }
}
