using Unity.VisualScripting;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private CircleCollider2D _circleCollider;

  
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 7)
        {
            Destroy(gameObject);
        }
    }
}
