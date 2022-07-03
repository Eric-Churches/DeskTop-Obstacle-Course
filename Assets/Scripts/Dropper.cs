using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float waitTimer = 5f;

    private MeshRenderer _renderer;
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _renderer.enabled = false;

        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > waitTimer)
        {
           _renderer.enabled= true;
           _rigidbody.useGravity = true;
        }
    }
}
