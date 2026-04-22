using System;
using System.Collections.Generic;
using System.Text;

namespace Plankton {
    public interface IMeshIdentityProvider<TVertex, TEdge, TFace> {
        TVertex NewVertexIdentity(PlanktonVertex<TVertex> vertex);
        TEdge NewEdgeIdentity(PlanktonHalfedge<TEdge> edge);
        TFace NewFaceIdentity(PlanktonFace<TFace> face);

        void OnRemoveVertex(PlanktonVertex<TVertex> vertex);
        void OnRemoveEdge(PlanktonHalfedge<TEdge> edge);
        void OnRemoveFace(PlanktonFace<TFace> face);
    }
}
