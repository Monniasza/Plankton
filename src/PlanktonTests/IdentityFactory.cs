using System;
using System.Collections.Generic;
using System.Text;
using Plankton;

namespace PlanktonTests {
    public class IdentityFactory: IMeshIdentityProvider<int, int, int> {
        public static PlanktonMesh<int, int, int> CreateMesh() {
            var identityProvider = new IdentityFactory();
            return new(identityProvider);
        }

        private int counter = 0;
        public int NewEdgeIdentity(PlanktonHalfedge<int> edge) {
            return ++counter;
        }

        public int NewFaceIdentity(PlanktonFace<int> face) {
            return ++counter;
        }

        public int NewVertexIdentity(PlanktonVertex<int> vertex) {
            return ++counter;
        }

        public void OnRemoveEdge(PlanktonHalfedge<int> edge) {
            //unused
        }

        public void OnRemoveFace(PlanktonFace<int> face) {
            //unused
        }

        public void OnRemoveVertex(PlanktonVertex<int> vertex) {
            //unused
        }
    }
}
