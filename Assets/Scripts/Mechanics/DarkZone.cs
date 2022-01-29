using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    public class DarkZone : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
			    var uac = GameObject.Find("Main Camera").GetComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>();
				uac.renderPostProcessing = true;
            }
    
        }
        void OnTriggerExit2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
			    var uac = GameObject.Find("Main Camera").GetComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>();
				uac.renderPostProcessing = false;
            }
    
        }
    }
}