using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameMap : MonoBehaviour
{
    public Transform m_tfMap3D;
    public Transform m_tfPlayer3D;

    public RectTransform m_rtMap2D;
    public RectTransform m_rtPlayer2D;

    public float m_fMap3DWidth = 1;
    public float m_fMap3DHeight = 1;
    public float m_fMap2DWidth = 1;
    public float m_fMap2DHeight = 1;
    public float m_fPlayer3DWidth = 1;
    public float m_fPlayer3DHeight = 1;
    public float m_fPlayer2DWidth = 1;
    public float m_fPlayer2DHeight = 1;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v2MapScale3D = new Vector2(1 - m_fPlayer3DWidth/m_fMap3DWidth, 1 - m_fPlayer3DHeight/m_fMap3DHeight);
        Vector2 v2MapScale2D = new Vector2(1 - m_fPlayer2DWidth/m_fMap2DWidth, 1 - m_fPlayer2DHeight/m_fMap2DHeight);
        Vector2 v2MapScale32 = v2MapScale2D / v2MapScale3D;
        Vector3 v3Delta = m_tfPlayer3D.position - m_tfMap3D.position;
        Vector2 v2Delta = new Vector2(v3Delta.x * m_fPlayer3DWidth/m_fMap3DWidth, v3Delta.z * m_fPlayer3DHeight/m_fMap3DHeight);
        m_rtPlayer2D.localPosition = new Vector2(v2Delta.x*m_rtMap2D.rect.width, v2Delta.y*m_rtMap2D.rect.height) * v2MapScale32;
    }
}
