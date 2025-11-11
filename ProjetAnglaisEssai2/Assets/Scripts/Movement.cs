using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] GameObject perso;
    [SerializeField] float swimSpeed;
    [SerializeField] Animator anim;

    CharacterController characControl;

    Vector2 move = Vector2.zero;


    void Start()
    {
        characControl = GetComponent<CharacterController>();
    }

    void Update()
    {
        Nage();
    }

    private void Nage()
    {
        Vector3 direction = perso.transform.forward * move.y ;

        if(characControl != null && Time.timeScale != 0)
        {
            characControl.Move(direction * swimSpeed * Time.deltaTime);
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
        anim.SetBool("isSwimming", move.magnitude > 0.1f);
    }
}
