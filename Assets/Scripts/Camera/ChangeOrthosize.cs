using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeOrthosize : MonoBehaviour
{
    float PlayerMagnitude;
    public CinemachineVirtualCamera vcam;
    int InitOrthographicSize = 12;

    void Start(){
        vcam.m_Lens.OrthographicSize = InitOrthographicSize;
    }    
    void FixedUpdate(){
        if (!Input.GetMouseButton(0)){
            PlayerMagnitude = ShootToMouse.PlayerVelocity.magnitude;
            if(PlayerMagnitude > InitOrthographicSize){
                vcam.m_Lens.OrthographicSize = Mathf.Max(8, Mathf.Min(vcam.m_Lens.OrthographicSize+0.2f, 20));
            }
            else{
                vcam.m_Lens.OrthographicSize = Mathf.Max(8, Mathf.Min(vcam.m_Lens.OrthographicSize-0.1f, 20));
            }
        }
    }
}
