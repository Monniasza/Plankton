using System;

namespace Plankton
{
    /// <summary>
    /// Represents a vertex in Plankton's halfedge mesh data structure.
    /// </summary>
    public class PlanktonVertex<T>
    {
        public int OutgoingHalfedge { get; internal set; }
        public readonly T Data;

        /// <summary>
        /// Creates a new unset PlanktonVertex. Unset vertices have an outgoing halfedge index of -1.
        /// </summary>
        internal PlanktonVertex(Func<PlanktonVertex<T>, T> ident)
        {
            this.OutgoingHalfedge = -1;
            this.Data = ident(this);
        }
        
        /// <summary>
        /// Whether or not the vertex is currently being referenced in the mesh.
        /// </summary>
        public bool IsUnused { get { return (this.OutgoingHalfedge < 0); } }
    }
}
