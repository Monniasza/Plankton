using System;

namespace Plankton
{
    /// <summary>
    /// Represents a face in Plankton's halfedge mesh data structure.
    /// </summary>
    public class PlanktonFace<TFace>
    {
        public int FirstHalfedge;
        public readonly TFace Identity;
        
        internal PlanktonFace(int halfedgeIndex, Func<PlanktonFace<TFace>, TFace> ident)
        {
            this.FirstHalfedge = halfedgeIndex;
            this.Identity = ident(this);
        }
        
        /// <summary>
        /// Whether or not the face is currently being referenced in the mesh.
        /// </summary>
        public bool IsUnused { get { return (this.FirstHalfedge < 0); } }
    }
}
