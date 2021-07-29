using Mapbox.Unity.Map;
using Mapbox.Utils;
using UnityEngine;

public class MapBoxInitialize : MonoBehaviour
{
    [SerializeField]
    Vector2 position;
    [SerializeField]
    Transform target;
    [SerializeField]
    AbstractMap _map;
    [SerializeField]
    Vector2d geoCoord;

    // Start is called before the first frame update
    void Start()
    {
        //_map.Initialize(location.LatitudeLongitude, _map.AbsoluteZoom);
        //_map.UseWorldScale();
        //geoCoord = _map.WorldToGeoPosition(target.position);
        geoCoord = new Vector2d(35.69, 139.69);
        _map.Initialize(geoCoord, _map.AbsoluteZoom);
    }

    // Update is called once per frame
    void Update()
    {
        target.transform.localPosition = _map.GeoToWorldPosition(geoCoord);
        Debug.Log(target.transform.localPosition);
    }
}
