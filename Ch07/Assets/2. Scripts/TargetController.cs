using UnityEngine;

public class TargetController : MonoBehaviour
{

    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }
    private void Update()
    {
        transform.LookAt(player.transform);   
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
