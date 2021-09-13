//------------------------------------------------------------
// Starpelly (the unity library)
// Homepage: https://starpelly.starpelly.com
// Do What The F*ck You Want To Public License (© 2004 Sam Hocevar <sam@hocevar.net>)
//------------------------------------------------------------

using UnityEngine;

namespace Starpelly.Utils.Sprites
{
    public class SpriteShadow : MonoBehaviour
    {
        public Vector2 offset = new Vector2(-3, -3);

        private SpriteRenderer spriteRendererCaster;
        private SpriteRenderer spriteRendererShadow;

        private Transform transformCaster;
        private Transform transformShadow;

        public Material shadowMaterial;
        public Color shadowColor;

        public Vector3 sizeMutlipler = new Vector2(0.15f, 0.15f);

        private void Start()
        {
            transformCaster = transform;
            transformShadow = new GameObject().transform;
            transformShadow.parent = transformCaster;
            transformShadow.gameObject.name = "Shadow";
            transformShadow.localRotation = Quaternion.identity;
            transformShadow.localScale = Vector3.one;

            spriteRendererCaster = GetComponent<SpriteRenderer>();
            spriteRendererShadow = transformShadow.gameObject.AddComponent<SpriteRenderer>();

            spriteRendererShadow.material = shadowMaterial;
            spriteRendererShadow.color = shadowColor;
            spriteRendererShadow.sortingLayerName = spriteRendererCaster.sortingLayerName;
            spriteRendererShadow.sortingOrder = spriteRendererCaster.sortingOrder - 21;
        }

        private void LateUpdate()
        {
            transformShadow.localScale = transformCaster.localScale + sizeMutlipler;

            transformShadow.position = new Vector2(transformCaster.position.x + offset.x,
                transformCaster.position.y + offset.y);

            spriteRendererShadow.sprite = spriteRendererCaster.sprite;
        }
    }
}