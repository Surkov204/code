
using UnityEngine;

public class PlayerDash : PlayerMoverment
{
    [SerializeField] private float dashBoost;
    [SerializeField] private float dashTime;
    [SerializeField] private AudioClip soundDash;

    private float _dashTime;
    private bool isDashing = false;

    private void Update()
    {
      

    }
}
