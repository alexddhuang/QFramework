using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using QF.Res;

namespace QFramework.Example
{
    public class LoadResourcesResExample : MonoBehaviour
    {
        public RawImage mImage;

        private ResLoader mResLoader = ResLoader.Allocate();

        // Start is called before the first frame update
        void Start()
        {
            mImage.texture = mResLoader.LoadSync<Texture2D>("resources://snap");
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void OnDestroy()
        {
            mResLoader.Recycle2Cache();
            mResLoader = null;
        }
    }
}
