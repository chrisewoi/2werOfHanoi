using UnityEngine;

public class Tower : MonoBehaviour
{
    public Transform towerAnchor;

    public Transform GetTopTile()
    {
        return towerAnchor.childCount > 0 ? towerAnchor.GetChild(0) : null;
        
        if (towerAnchor.childCount > 0)
            return towerAnchor.GetChild(0);
        else
            return null;
    }
}
