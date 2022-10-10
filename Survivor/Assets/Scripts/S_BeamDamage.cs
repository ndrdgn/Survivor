using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_BeamDamage : MonoBehaviour
{

    public int spellDamage;
    [SerializeField] float lifeTime;
    private void OnTriggerEnter2D(Collider2D other) {
        
            InterfaceDamagable e = other.GetComponent<InterfaceDamagable>();
            if(e != null){
                e.TakeDamage(spellDamage);
            }
    }
    private void Update() {
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0){
            //Destroy(gameObject);
        }
    }
    
}
