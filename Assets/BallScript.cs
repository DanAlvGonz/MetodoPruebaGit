using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed = 8f;
    public float limDirYneg = -0.9f;
    public float limDirYpos = 0.9f;
    private Rigidbody2D rb;
    private GameManager gm;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    void Launch()
    {
        float x = Random.value < 0.5f ? -1 : 1;
        float y = Random.Range(-0.5f, 0.5f);

        Vector2 dir = new Vector2(x, y).normalized;
        rb.linearVelocity = dir * speed;
    }

    void Update()
    {
        if (Mathf.Abs(transform.position.x) > 20f)
        {
            if (transform.position.x > 11f)
            {

                gm.ScoreLeft();

            }
        }
        else
        {
            gm.ScoreRight();
        }
        transform.position = Vector2.zero;
        Launch();
    }

}