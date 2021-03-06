using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerMoudle;
public class DrawLineToMouse : MonoBehaviour
{
     private LineRenderer _lineRenderer;
     public Color c1;
     public Color c2;
     public Material mat;
     public void Start()
     {
         _lineRenderer = gameObject.AddComponent<LineRenderer>();
         _lineRenderer.sortingLayerName = "Foreground";
         _lineRenderer.material = mat;
         _lineRenderer.startWidth = 0.4f;
         _lineRenderer.endWidth = 0.2f;
         _lineRenderer.startColor = c1;
         _lineRenderer.endColor = c2;
         _lineRenderer.enabled = false;
     }
 
     private Vector3 _initialPosition;
     private Vector3 _currentPosition;
     private Vector3 posInScreen;
     public void Update()
     {
         if (Input.GetMouseButtonDown(0))
         {
            _initialPosition = transform.position;
            _lineRenderer.SetPosition(0, _initialPosition);
            _lineRenderer.positionCount = 1;
            _lineRenderer.enabled = true;
         } 
         else if (Input.GetMouseButton(0))
         {
            _currentPosition = pm.GetCurrentMousePosition().GetValueOrDefault();
            _initialPosition = transform.position;
            _lineRenderer.positionCount = 2;
            _lineRenderer.SetPosition(0, _initialPosition);
            _lineRenderer.SetPosition(1, _currentPosition);
 
         } 
         else if (Input.GetMouseButtonUp(0))
         {
             _lineRenderer.enabled = false;
         }
     }
 }
