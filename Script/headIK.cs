using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headIK : MonoBehaviour
{
    protected Animator animator; /* Armazena o animator do personagem */

    public Transform target; /* Armazena o transform do Alvo  */
    public bool ikActive = true; /* ACTIVAR O INVERSE KINEMATIC */

    void Start()
    {
      target = GameObject.Find("cabeca").transform; /* Objecto vasio colocado como filho do osso da cabeça do alvo */
     animator = transform.GetComponent<Animator>(); /* Pegando o Componente Animator do Personagem com esse script */
    }
   
   void OnAnimatorIK()
    {
        if(animator) {
           
            if(ikActive) {
                if(target != null) {
                    animator.SetLookAtWeight(1);
                    animator.SetLookAtPosition(target.position);
                   
                }      
                
            }
            else {          
                
                animator.SetLookAtWeight(0);
            }
        }
    }
}
