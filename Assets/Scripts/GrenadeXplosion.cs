using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeXplosion : MonoBehaviour
{
    public float XplosionDelay = 3;
    public GameObject XplosionParticlePrefab;
    public GameObject GrenadeTab;
    public GameObject GrenadeTabVisual; //dont worry its all for beauty
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Xplosion", XplosionDelay);
        GrenadeTab.SetActive(true);
        Destroy(GrenadeTabVisual);
    }
    void Xplosion()
    {
        Destroy(gameObject);
        var ParticleInst = Instantiate(XplosionParticlePrefab);
        ParticleInst.transform.position = transform.position;
    }
}
