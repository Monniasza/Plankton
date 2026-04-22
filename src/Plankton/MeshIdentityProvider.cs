using System;
using System.Collections.Generic;
using System.Text;

namespace Plankton {
    public interface IMeshIdentityProvider<TVertex, TEdge, TFace> {
        TVertex NewVertexIdentity(PlanktonVertex<TVertex> vertex);
        TEdge NewEdgeIdentity(PlanktonEdge<TEdge> edge);
        TFace NewFaceIdentity(PlanktonFace<TFace> face);
    }
}
