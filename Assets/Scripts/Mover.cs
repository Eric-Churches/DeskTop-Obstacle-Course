using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 6.2f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

// Update is called once per frame
    private void Update()
    {
        MovePlayer();
        
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to my game!!!!!");
        Debug.Log("Use the WASD or arrow keys");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer()
    {
        
        float xValue = Input.GetAxis("Horizontal") * (moveSpeed * Time.deltaTime);
        float zValue = Input.GetAxis("Vertical") * (moveSpeed * Time.deltaTime);
        transform.Translate(xValue, 0, zValue);
    }
}