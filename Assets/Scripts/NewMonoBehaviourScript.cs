using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
     private Animator viktorsAnimator;  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        viktorsAnimator = GetComponent<Animator>();

        viktorsAnimator.SetBool("Run", false);

        viktorsAnimator.SetBool("Jump", false);
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            viktorsAnimator.SetBool("Run", true);
        }

        if (Input.GetKeyUp("d"))
        {
            viktorsAnimator.SetBool("Run", false);
        }
        

        
        if (Input.GetKeyDown("a"))
        {
            viktorsAnimator.SetBool("Run", true);
        }

        if (Input.GetKeyUp("a"))
        {
            viktorsAnimator.SetBool("Run", false);
        }

        
        
        if (Input.GetButtonDown("Jump")) 
        {
            viktorsAnimator.SetBool("Jump", true);
        }
        
        if (Input.GetButtonUp("Jump")) 
        {
            viktorsAnimator.SetBool("Jump", false);
        }

    }
}
