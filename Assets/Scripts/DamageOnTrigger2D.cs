using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DamageOnTrigger2D : MonoBehaviour
{
    public string[] DamagingTags;
    public int DamagePerHit = 1;
    public int TotalHealth = 3;
    public Text VisualHealth;
    public AudioClip HitSound;

    private AudioSource Audio;
    private int CurrentHealth = 3;

    private void Start()
    {
        Audio = this.GetComponent<AudioSource>();
        CurrentHealth = TotalHealth;
        UpdateUI();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(DamagingTags.Contains(collider.gameObject.tag))
        {
            TakeDamage(DamagePerHit);
        }
    }

    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;

        Audio.PlayOneShot(HitSound);
        UpdateUI();

        if (CurrentHealth <= 0)
            GameInformation.GameOver();
    }

    void UpdateUI()
    {
        if (VisualHealth)
            VisualHealth.text = CurrentHealth.ToString();
    }
}
