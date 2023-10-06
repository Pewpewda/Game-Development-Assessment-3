using UnityEngine;

public class MopManMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed = 5f;
    public Animator characterAnimator;

    private int currentWaypointIndex = 0;
    private Vector3 lastWaypointPosition;

    private void Start()
    {
        lastWaypointPosition = transform.position;
    }

    private void Update()
    {
        if (waypoints.Length == 0)
        {
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            Vector3 direction = waypoints[currentWaypointIndex].position - lastWaypointPosition;
            direction.Normalize();

            if (direction == Vector3.up)
            {
                characterAnimator.Play("MopMan_Up");
            }

            else if (direction == Vector3.down)
            {
                characterAnimator.Play("MopMan_Down");
            }

            else if (direction == Vector3.left)
            {
                characterAnimator.Play("MopMan_Left");
            }

            else if (direction == Vector3.right)
            {
                characterAnimator.Play("MopMan_Right");
            }

            lastWaypointPosition = waypoints[currentWaypointIndex].position;

            currentWaypointIndex++;

            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
    }
}



