using System.Collections.Generic;
using System.Numerics;

namespace HLMapFileLoader;

public class Polygon
{
    public Polygon(Plane plane, Face face)
    {
        Face = face;
        TextureScales = new();
        Vertices = new();
        Plane = plane;
        Texture = new(16, 16); // TODO: Get from face.TextureName
    }

    public List<Vector3> Vertices { get; }
    public List<Vector2> TextureScales { get; }
    public Plane Plane { get; }
    public Face Face { get; }
    public Texture Texture { get; }
}
