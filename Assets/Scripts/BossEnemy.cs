using UnityEngine;
using UnityEngine.Events;


public class BossEnemy : Enemy
{
    public string initialMessage = "Time to die, Mr. Blob!";
    public string playerLoseMessage = "We win again!";
    public string playerWinMessage = "Aaaargh!!!";
    public UnityEvent onGameWin;

    protected override void Start()
    {
        base.Start();
        healthLabel.text = initialMessage;
    }
    public override void Move()
    {
        direction = transform.position - Vector3.zero;
        Vector3 rotatedDirection = Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.forward) * direction;
        transform.position = rotatedDirection;
    }

    protected override void TriggerDeath()
    {
        onGameWin.Invoke();
    }

    public void showPlayerLoseMessage()
    {
        healthLabel.text = playerLoseMessage;
    }

    public void showPlayerWinMessage()
    {
        healthLabel.text = playerWinMessage;
    }
}
