using UnityEngine;
using UnityEngine.InputSystem;

public class Bowling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int forcePower;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
            ShootBall();
        if (Keyboard.current.rightArrowKey.isPressed
            || Keyboard.current.dKey.isPressed)
            Moveright();
        if (Keyboard.current.leftArrowKey.isPressed
            || Keyboard.current.dKey.isPressed)
            Moveleft();
    }

    public void ShootBall()
    {
        rb.AddForce(Vector3.forward*forcePower,ForceMode.Impulse);
    }

    private void Moveright()
    {
        gameObject.transform.position += new Vector3(5f, 0f, 0f)* Time.deltaTime;

    }

    private void Moveleft()
    {
        gameObject.transform.position += new Vector3(-5f, 0f, 0f) * Time.deltaTime;

    }
}
