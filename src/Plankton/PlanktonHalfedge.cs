using System;

namespace Plankton
{
    /// <summary>
    /// Represents a halfedge in Plankton's halfedge mesh data structure.
    /// </summary>
    public class PlanktonHalfedge<TEdge>
    {
        public int StartVertex;
        public int AdjacentFace;
        public int NextHalfedge;
        public int PrevHalfedge;
        public readonly TEdge Data;

        /// <summary>
        /// Creates a new unset PlanktonHalfedge.
        /// </summary>
        public PlanktonHalfedge(Func<PlanktonHalfedge<TEdge>, TEdge> ident) {
            StartVertex = -1;
            AdjacentFace = -1;
            NextHalfedge = -1;
            PrevHalfedge = -1;
            Data = ident(this);
        }

        internal PlanktonHalfedge(int Start, int AdjFace, int Next, Func<PlanktonHalfedge<TEdge>, TEdge> ident)
        {
            StartVertex = Start;
            AdjacentFace = AdjFace;
            NextHalfedge = Next;
            Data = ident(this);
        }
        
        /// <summary>
        /// <para>Whether or not the vertex is currently being referenced in the mesh.</para>
        /// <para>Defined as a halfedge which has no starting vertex index.</para>
        /// </summary>
        public bool IsUnused { get { return (this.StartVertex < 0); } }
    }
}
