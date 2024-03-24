using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GrenadeCaster : MonoBehaviour
{
    public Rigidbody GrenadeAlienPrefab;
    public Transform GrenadeThrowPoint;
    public float ThrowForce;
    public int GrenadeType = 0;
    public int GrenadeAmount = 3;
    public TextMeshProUGUI GrenadeCountText;
    public GameObject Ship;
    void Start()
    {
        
    }

    void Update()
    {
        GrenadeThrow();
        GrenadeUIUpdate();
    }
    void GrenadeThrow()
    {
        if (Input.GetMouseButtonDown(1) && GrenadeType == 0 && GrenadeAmount > 0)
        {
            var grenadeInst = Instantiate(GrenadeAlienPrefab);
            grenadeInst.transform.position = GrenadeThrowPoint.position;
            grenadeInst.GetComponent<Rigidbody>().AddForce(GrenadeThrowPoint.forward * ThrowForce);
            GrenadeAmount -= 1;

        }
    }
    void GrenadeUIUpdate()
    {
        GrenadeCountText.text = GrenadeAmount.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        var GrenadesGivin = other.GetComponent<AlienGrenadesBase>();
        if (GrenadesGivin != null)
        {
            GrenadeAmount += GrenadesGivin.AmountToGive;
        }
    }
}
