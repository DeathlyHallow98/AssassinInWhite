﻿#if UNITY_EDITOR
using UnityEngine;

namespace O3DWB
{
    public class ObjectLayersSceneRenderPath : SceneRenderPath
    {
        #region Public Methods
        public override void RenderGizmos()
        {
            ObjectSnapping.Get().XZSnapGrid.RenderGizmos();
            ObjectSelection.Get().RenderGizmos();
        }

        public override void RenderHandles()
        {
            ObjectSelection.Get().RenderHandles();
        }
        #endregion
    }
}
#endif