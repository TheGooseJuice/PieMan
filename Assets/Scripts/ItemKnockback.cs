using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemKnockback : MonoBehaviour {



   public bool IsCat;

    public void OnTriggerEnter(Collider other) {
         
          

         if(other.gameObject.tag =="Bullet"){

          // calculate force vector
            Vector3 m_force = transform.position - other.transform.position;
            gameObject.GetComponent<Rigidbody>().AddForce(m_force, ForceMode.Impulse);

            gameObject.GetComponent<Rigidbody>().AddTorque(transform.up * 100);    
            gameObject.GetComponent<Rigidbody>().AddTorque(transform.right * 100);
            gameObject.GetComponent<Collider>().enabled=false;
            gameObject.GetComponent<Rigidbody>().AddTorque(transform.up * 100);    
            gameObject.GetComponent<Rigidbody>().AddTorque(transform.right * 100);
           gameObject.GetComponent<Collider>().enabled=false;

            StartCoroutine(WaitForDestroy());
         }
     
}
 private IEnumerator WaitForDestroy()
    {
       
           yield return new WaitForSeconds(5);
            Destroy(gameObject);
           
        
    }

}