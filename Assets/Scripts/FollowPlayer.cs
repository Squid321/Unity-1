using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

    public GameObject player;
    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0,5,-7);
    }
}
