using UnityEngine;
using UnityEngine.Rendering;

/// <summary>
/// Enables shadow casting on SpriteRenderer
/// You can also do that using Debug Inspector
/// </summary>
public class SpriteShadowCaster : MonoBehaviour
{
    // Inspector
    [Header("References")]
    [SerializeField] private SpriteRenderer _spr;
    
    private void Start() => CastShadows();

    private void CastShadows()
    {
        if (_spr == null)
            return;

        _spr.shadowCastingMode = ShadowCastingMode.On;
        _spr.receiveShadows = true;
    }
}
