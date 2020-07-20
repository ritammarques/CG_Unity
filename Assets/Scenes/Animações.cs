
using UnityEngine;

public class Animações : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    int jumpHash = Animator.StringToHash("Jump");
    int rotateRightHash = Animator.StringToHash("RotateRight");
    int rotateLeftHash = Animator.StringToHash("RotateLeft");

   
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        //andar e correr
        float move = Input.GetAxis ("Vertical");
        animator.SetFloat("Speed", move);


        //saltar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger(jumpHash);
        }
        //Rodar Direita
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetTrigger(rotateRightHash);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetTrigger(rotateLeftHash);
        }
      
    }
}
