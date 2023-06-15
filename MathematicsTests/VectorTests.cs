﻿using Mathematics.Vectors;
using System.Runtime.Intrinsics;

namespace MathematicsTests;

public class VectorTests
{
    [Fact]
    public void ElementaryVectorConstructorWorks()
    {
        IVector vec = new Vector(5);

        Assert.Equal(5, vec.Size);
    }

    [Fact]
    public void FloatArrayConstructorWorks()
    {
        float[] floats = { 3.0f, 5.0f, -2.0f };

        IVector vec = new Vector(floats);

        Assert.Equal(3, vec.Size);
    }

    [Fact]
    public void CopyConstructorBehavesWell()
    {
        float[] floats = { 1.0f, 3.0f, 5.0f, -4.0f };

        IVector vec1 = new Vector(floats);
        IVector vec2 = new Vector(vec1);

        Assert.True(vec1.Equals(vec2));
    }

    [Fact]
    public void OneIndexedItemBehavesWell()
    {
        float[] floats = { 1.0f, 2.0f, 3.0f, 4.0f };

        IVector vec1 = new Vector(floats);

        Assert.Equal(2.0f, vec1.Item(2));
    }

    [Fact]
    public void ZeroIndexedItemBehavesWell()
    {
        float[] floats = { 1.0f, 2.0f, 3.0f, 4.0f };

        IVector vec1 = new Vector(floats);

        Assert.Equal(1.0f, vec1.Item0I(0));
    }

    [Fact]
    public void OneIndexedSetItemBehavesWell()
    {
        float[] floats = { 1.0f, 2.0f, 3.0f, 4.0f };

        IVector vec1 = new Vector(floats);

        vec1.SetItem(1, 5.0f);

        Assert.Equal(5.0f, vec1.Item(1));
    }

    [Fact]
    public void ZeroIndexedSetItemBehavesWell()
    {
        float[] floats = { 1.0f, 2.0f, 3.0f, 4.0f };

        IVector vec1 = new Vector(floats);

        vec1.SetItem0I(2, 42.0f);

        Assert.Equal(42.0f, vec1.Item(3));
    }

    [Fact]
    public void ToArrayBehavesWell()
    {
        float[] floats = { 1.0f, 2.0f, 3.0f, 4.0f };

        IVector vec1 = new Vector(floats);

        float[] returnRes = vec1.ToArray();
        for(int i = 0; i < floats.Length; i++)
        {
            Assert.Equal(floats[i], returnRes[i]);
        }
    }

    [Fact]
    public void AdditionBehavesWell()
    {
        float[] floats = { 1.0f, 2.0f, 3.0f, 4.0f };

        IVector vec1 = new Vector(floats);

        IVector vec2 = new Vector(floats);

        IVector vec3 = vec1 + vec2;

        for (int i = 0; i < floats.Length; i++)
        {
            Assert.Equal(2 * floats[i], vec3.ToArray()[i]);
        }
    }

    [Fact]
    public void SubtractionBehavesWell()
    {
        float[] floats = { 1.0f, 2.0f, 3.0f, 4.0f };

        IVector vec1 = new Vector(floats);

        IVector vec2 = new Vector(floats);

        IVector vec3 = vec1 - vec2;

        for (int i = 0; i < floats.Length; i++)
        {
            Assert.Equal(0.0f, vec3.ToArray()[i]);
        }
    }
}
