using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private HealthSystem health;
    public GameObject cam;
    public void HealthUpdate(HealthSystem health)
    {
        this.health = health;
        health.OnHealthUpdate += Health_OnHealthUpdate;
    }

    private void Health_OnHealthUpdate(object sender, System.EventArgs e)
    {
        var image = transform.Find("HealthBar/Background/Fill").GetComponent<Image>();
        var canvas = transform.Find("HealthBar");
        image.fillAmount=health.GetHealthPercentage();
        canvas.transform.LookAt(cam.transform);
        

    }

    
}
