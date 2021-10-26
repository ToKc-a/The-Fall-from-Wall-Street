using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool lose = false;

    private void Awake()
    {
        lose = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            lose = true;
        }
    }
}
